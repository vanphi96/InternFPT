
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

        
      
        private void button1_Click(object sender, EventArgs e)
        {
            //userList();
            //acd();
           information= Ldap.Login2(txt_user,txt_pass,lb_infor);
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

        private void button2_Click(object sender, EventArgs e)
        {
            Ldap.CreateUser();
        }
    }
}
