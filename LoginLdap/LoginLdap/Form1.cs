
using Novell.Directory.Ldap;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginLdap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void userList()
        {
            string ldapHost = "ldap://10.1.7.28";
            int ldapPort = 0;
            string loginDN = "CN=admin,CN=Users,DC=vietis,DC=local";
            string password = "vietis@123";
            string searchBase = "ou=users,o=Company";
            string searchFilter = "objectClass=inetOrgPerson";

            try
            {

                LdapConnection conn = new LdapConnection();
                // Console.WriteLine("Connecting to " + ldapHost);
                conn.Connect(ldapHost, 3268);
                conn.Bind(loginDN, password);
                string[] requiredAttributes = { "cn", "sn", "uid" };
                LdapSearchResults lsc = conn.Search(searchBase,
                                    LdapConnection.SCOPE_SUB,
                                    searchFilter,
                                    requiredAttributes,
                                    false);
                while (lsc.hasMore())
                {
                    LdapEntry nextEntry = null;
                    try
                    {
                        nextEntry = lsc.next();

                    }
                    catch (LdapException e)
                    {
                        Console.WriteLine("Error : " + e.LdapErrorMessage);
                        continue;
                    }
                    Console.WriteLine("\n" + nextEntry.DN);
                    LdapAttributeSet attributeSet = nextEntry.getAttributeSet();
                    System.Collections.IEnumerator ienum = attributeSet.GetEnumerator();
                    while (ienum.MoveNext())
                    {
                        LdapAttribute attribute = (LdapAttribute)ienum.Current;
                        string attributeName = attribute.Name;
                        string attributeVal = attribute.StringValue;
                       MessageBox.Show("\t" + attributeName + "\tvalue  = \t" + attributeVal);
                    }
                }
                conn.Disconnect();


            }
            catch (LdapException e)
            {
                Console.WriteLine("Error :" + e.LdapErrorMessage);
                return;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error :" + e.Message);
                return;
            }
            Console.WriteLine("Press any key ");
            Console.ReadKey(true);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            userList();
            //acd();
        }
        private void acd()
        {
            var directoryEntry = new DirectoryEntry("ldap://10.1.7.28");
            directoryEntry.Username = "CN=admin,CN=Users,DC=vietis,DC=local";
            directoryEntry.Password = "vietis@123";

            var directorySearcher = new DirectorySearcher(directoryEntry);
            int a = 0;
            directorySearcher.FindAll();
            int b = 0;
        }

    }
}
