
using Novell.Directory.Ldap;
using System;
using System.Collections;
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
        List<String> information = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }
        public void userList()
        {
            string ldapHost = "ldap://10.1.7.28";
            int ldapPort = 389;
            string loginDN = "CN=admin,CN=Users,DC=vietis,DC=local";
            string password = "vietis@123";
            string searchBase = "ou=users,o=Company";
            string searchFilter = "objectClass=inetOrgPerson";
            

            try
            {

                LdapConnection conn = new LdapConnection();
                // Console.WriteLine("Connecting to " + ldapHost);
                conn.Connect(ldapHost, ldapPort);
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

        
        public void Login2()
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

            ArrayList listaPropiedades = new ArrayList();
            using (DirectoryEntry directoryEntry = new DirectoryEntry(addServer, ldap_user, ldap_pass))
            {
                using (DirectorySearcher ds = new DirectorySearcher(directoryEntry))
                {
                    try
                    {
                      
                        ds.Filter = "(sAMAccountName=" + username + ")";
                      
                        //string[] requiredProperties = new string[] { "givenname", "cn", "sn", "distinguishedName", "displayName", "name"};



                        //SearchResultCollection all = ds.FindAll();
                        //foreach (SearchResult item in all)
                        //{
                        //    ResultPropertyCollection propaa = item.Properties;
                        //    foreach (string propname in propaa.PropertyNames)
                        //    {
                        //        foreach (Object collection in propaa[propname])
                        //        {
                        //            string straa = propname + " : " + collection.ToString();
                        //            lb_infor.Items.Add(straa);
                        //            information.Add(straa);


                        //        }

                        //    }
                        //}
                       // ds.PropertiesToLoad.Add("name");
                        var result = ds.FindOne();
                        StringBuilder str = new StringBuilder();
                        ResultPropertyCollection prop = result.Properties;
                        ICollection coll = prop.PropertyNames;
                        IEnumerator enu = coll.GetEnumerator();
                        while (enu.MoveNext())
                        {
                            str.Append(enu.Current + " = " + result.Properties[enu.Current.ToString()][0] + "\n");
                        }
                        //MessageBox.Show(str.ToString());
                        //string _filterAttribute = (string)result.Properties["name"][0];
                        //MessageBox.Show(_filterAttribute);
                        //foreach (String property in requiredProperties)


                        ResultPropertyCollection fields = result.Properties;

                        string name = result.Properties["name"][0].ToString();
                        using (DirectoryEntry directoryEntryUser = new DirectoryEntry(addServer, name, pass, AuthenticationTypes.None))
                        {
                          
                            try
                            {
                                object nativeObject = directoryEntryUser.NativeObject;
                                if (nativeObject != null)
                                {
                                    MessageBox.Show("Chào thằng em " + name);
                                }
                            }
                            catch (Exception e)
                            {

                                MessageBox.Show("Pass sai em nhé");
                            }
                           
                        }



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


            //return View();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            //userList();
            //acd();
            Login2();
        }
        void login(string nom, string pass)
        {
            string adPath = "LDAP://10.1.7.28";
            LDAPAutenticador aut = new LDAPAutenticador(adPath);
            ArrayList gruposDe = new ArrayList();
            ArrayList propUsuarios = new ArrayList();
            information = new List<string>();
            try
            {
                if (aut.autenticado("LDAP://10.1.7.28/DC=vietis,DC=local", "CN=admin,CN=Users,DC=vietis,DC=local", "vietis@123") == true)
                {
                    //lblUsuario.Text = aut.getCN();

                    //propUsuarios = aut.getListaPropiedades();
                    //ddlUsuarios.Items.Clear();
                    //ddlUsuarios.Items.Add(new ListItem(propUsuarios[0] as string));

                    //if (propUsuarios.Count > 1)
                    //{
                    //    lblName.Text = propUsuarios[1] as string;
                    //    lblApellido.Text = propUsuarios[2] as string;
                    //    lblUsuario.Text = propUsuarios[0] as string;
                    //}

                    //llenarGrupos(lblUsuario.Text);

                    //gruposDe = aut.GetGroups();
                    //listaGrupos.Items.Clear();
                    //for (int i = 0; i < gruposDe.Count; i++)
                    //{
                    //    listaGrupos.Items.Add(new ListItem(gruposDe[i] as string));
                    //    if (gruposDe[i] as string == "Administrators")
                    //    {
                    //        Response.Write("Bienvenido administrador");
                    //    }
                    //}
                }
            }
            catch (Exception ex)
            {
                //ScriptManager.RegisterStartupScript(this.Page, this.Page.GetType(), "error", "alert('" + ex.ToString() + "');", true);
                //Response.Redirect("inicio.aspx");
            }

        }
        
        //void llenarDdl(Object origen, EventArgs args)
        //{
        //    //llenarGrupos(ddlUsuarios.SelectedItem.Value);
        //    Response.Write(ddlUsuarios.SelectedItem.Value);
        //}

        //void llenarGrupos(string cn)
        //{
        //    string adPath = "LDAP://" + Session["dominio"];
        //    LDAPAutenticador aut = new LDAPAutenticador(adPath);
        //    ArrayList gruposDe = new ArrayList();
        //    ArrayList todosLosUsuarios = new ArrayList();
        //    gruposDe = aut.GetGroups(cn);
        //    listaGrupos.Items.Clear();
        //    for (int i = 0; i < gruposDe.Count; i++)
        //    {
        //        listaGrupos.Items.Add(new ListItem(gruposDe[i] as string));
        //        if (gruposDe[i] as string == "administrators")
        //        {
        //            Response.Write("Bienvenido administrador");
        //            //llamar todos los usuarios y agregarlos al ddl
        //            todosLosUsuarios = aut.getTodosUsuarios();
        //            for (int e = 0; e < todosLosUsuarios.Count; e++)
        //            {
        //                ddlUsuarios.Items.Add(new ListItem(todosLosUsuarios[e] as string));
        //            }
        //        }
        //    }
        //}

        //void Guardar_Cotraseña(Object origen, EventArgs args)
        //{
        //    if (txtNewPass.Text == txtConfirmPass.Text)
        //    {
        //        string adPath = "LDAP://" + Session["dominio"];
        //        LDAPAutenticador aut = new LDAPAutenticador(adPath);

        //        Response.Write(aut.modificaPass(txtConfirmPass.Text, (string)Session["user"], txtActualPass.Text));

              
        //    }
        //    else
        //    {
        //        errorLabel.Text = "Contraseñas no coinciden";
        //    }
        //}
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

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string search = txtSearch.Text;
            lb_infor.Items.Clear();
            foreach(var item in information.Where(x=>x.Contains(search)).ToList())
            {
                lb_infor.Items.Add(item);
            }
        }
    }
}
