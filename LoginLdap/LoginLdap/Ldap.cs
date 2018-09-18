using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data;
using System.DirectoryServices;
using System.Windows.Forms;
using System.DirectoryServices.AccountManagement;

namespace LoginLdap
{
   public class Ldap
    {
        public static List<string> Login2(TextBox txt_user, TextBox txt_pass, ListBox lb_infor)
        {
            string addServer = "LDAP://10.1.7.28/DC=vietis,DC=local";
            string ldap_user = "admin";
            string ldap_pass = "vietis@123";

            string username = txt_user.Text;
            string pass = txt_pass.Text;

            //using (PrincipalContext pc = new PrincipalContext(ContextType.Domain, null, addServer))
            //{
            //    // validate the credentials
            //    bool isValid = pc.ValidateCredentials(ldap_user, ldap_pass);
            //}
            List<string> information = new List<string>();
            ArrayList listaPropiedades = new ArrayList();
            using (DirectoryEntry directoryEntry = new DirectoryEntry(addServer, ldap_user, ldap_pass))
            {
                using (DirectorySearcher ds = new DirectorySearcher(directoryEntry))
                {
                    try
                    {
                        ds.Filter = "(sAMAccountName=" + username + ")";

                        //string[] requiredProperties = new string[] { "givenname", "cn", "sn", "distinguishedName", "displayName", "name"};
                        SearchResultCollection all = ds.FindAll();
                        foreach (SearchResult item in all)
                        {
                            ResultPropertyCollection propaa = item.Properties;
                            foreach (string propname in propaa.PropertyNames)
                            {
                                foreach (Object collection in propaa[propname])
                                {
                                    string straa = propname + " : " + collection.ToString();
                                    lb_infor.Items.Add(straa);
                                    information.Add(straa);


                                }

                            }
                        }
                        return information;
                        // ds.PropertiesToLoad.Add("name");
                        #region LAY RA CAC THUOC TINH TRONG LDAP
                        //var result = ds.FindOne();
                        //StringBuilder str = new StringBuilder();
                        //ResultPropertyCollection prop = result.Properties;
                        //ICollection coll = prop.PropertyNames;
                        //IEnumerator enu = coll.GetEnumerator();
                        //while (enu.MoveNext())
                        //{
                        //    str.Append(enu.Current + " = " + result.Properties[enu.Current.ToString()][0] + "\n");
                        //}
                        #endregion
                        //MessageBox.Show(str.ToString());
                        //string _filterAttribute = (string)result.Properties["name"][0];
                        //MessageBox.Show(_filterAttribute);
                        //foreach (String property in requiredProperties)

                        #region xet login thanh cong
                        //ResultPropertyCollection fields = result.Properties;

                        //string name = result.Properties["name"][0].ToString();
                        //using (DirectoryEntry directoryEntryUser = new DirectoryEntry(addServer, name, pass, AuthenticationTypes.None))
                        //{

                        //    try
                        //    {
                        //        object nativeObject = directoryEntryUser.NativeObject;
                        //        if (nativeObject != null)
                        //        {
                        //            MessageBox.Show("Chào thằng em " + name);
                        //        }
                        //    }
                        //    catch (Exception e)
                        //    {

                        //        MessageBox.Show("Pass sai em nhé");
                        //    }

                        //}

                        #endregion

                        //    ds.PropertiesToLoad.Add("name");

                        //SearchResultCollection all2 = ds.FindAll();
                        //StringBuilder stringResult = new StringBuilder();
                        //foreach (SearchResult item in all2)
                        //{
                        //    ResultPropertyCollection propaa = item.Properties;
                        //    foreach (string propname in propaa.PropertyNames)
                        //    {
                        //        foreach (Object collection in propaa[propname])
                        //        {
                        //            string straa = propname + " : " + collection.ToString() + "\n";
                        //            stringResult.Append(straa);
                        //        }

                        //    }
                        //}
                        //MessageBox.Show(stringResult.ToString());
                    }
                    catch (Exception e)
                    {

                        // MessageBox.Show(e.ToString());
                    }


                }
            }
            return new List<string>();

            //return View();
        }
        public static void CreateUser()
        {
            //string firstName, string lastName, string user, string employeeID, string emailAddress, string telephone, string address;
            //string addServer = "LDAP://10.1.7.28/DC=vietis,DC=local";
            //string ldap_user = "admin";
            //string ldap_pass = "vietis@123";
            //using (var pc = new PrincipalContext(ContextType.ApplicationDirectory, "LDAP://10.1.7.28/DC=vietis,DC=local", @"LDAP://10.1.7.28/DC=vietis,DC=local\admin", "vietis@123"))
            //{
            //    using (var up = new UserPrincipal(pc))
            //    {
            //        up.SamAccountName = "lv.phi";
            //        up.EmailAddress = "anc@gmail.com";
            //        up.SetPassword("phi@12345");
            //        up.DisplayName = "Le Van Phi";
            //        up.Enabled = true;
            //        up.ExpirePasswordNow();
            //        up.Save();

            //    }
            //}
            //return false;



            //string addServer = "LDAP://10.1.7.28/DC=vietis,DC=local";
            //string ldap_user = "admin";
            //string ldap_pass = "vietis@123";
            //string ADFullPath = "LDAP://192.168.0.10/OU=T2,OU=root,DC=admin,DC=domain,DC=com";
            //DirectoryEntry ouEntry = new DirectoryEntry(addServer, ldap_user, ldap_pass, AuthenticationTypes.Secure);
            //try
            //{
            //    DirectoryEntry childEntry = ouEntry.Children.Add("CN=TESTUSER" + 0, "Phi");
            //    childEntry.CommitChanges();
            //    ouEntry.CommitChanges();
            //    childEntry.Invoke("SetPassword", new object[] { "password22" });
            //    childEntry.CommitChanges();
            //    MessageBox.Show("creat user success!");
            //}
            //catch (Exception ex)
            //{


            //}


            DirectoryEntry objUser = new DirectoryEntry("LDAP://10.1.7.28/DC=vietis,DC=local", "admin", "vietis@123");
          //  DirectoryEntry NewUser = AD.Children.Add("CN=TestUser122", "user");

            string username = "phi.levanaa";
            string domain = "LDAP://10.1.7.28/DC=vietis,DC=local";
            string last = "Phi";
            string first = "Le Van";
            string description = "dev VietIS";
            string email = "phi.levan@vietis.com.vn";
            string password = "vietis@123";
            //NewUser.Invoke("SetPassword", new object[] { "#12345Abc" });
            //NewUser.Invoke("Put", new object[] { "Description", "Test User from .NET" });
            //NewUser.CommitChanges();

            //DirectoryEntry grp;
            //grp = AD.Children.Find("Guests", "group");
            //if (grp != null) { grp.Invoke("Add", new object[] { NewUser.Path.ToString() }); }


            //objUser.Properties["userPrincipalName"].Add(username + "@" + domain);

            // User name (older systems)           
            objUser.Properties["samaccountname"].Add(username);

            // Surname           
            objUser.Properties["sn"].Add(last);

            // Forename           
            objUser.Properties["givenname"].Add(first);

            // Display name           
            objUser.Properties["displayname"].Add(first + " " + last);

            // Description           
            objUser.Properties["description"].Add(description);

            // E-mail           
            objUser.Properties["mail"].Add(email);

            // Home dir (drive letter)           
            //objUser.Properties["homedirectory"].Add(homeDir);

            // Home dir (path)           
            //objUser.Properties["homedrive"].Add(homeDrive);
            //objUser.Invoke("SetPassword", password);
            objUser.CommitChanges();
            objUser.Properties["password"].Add(password);


        }
    }
}
