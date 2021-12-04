using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;
namespace Superomart
{
    public partial class enquiry : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["suchi"].ConnectionString);
            con.Open();
            string inscmd = "insert into shoppingmart(name,email_id,contact,password,time)values(@name,@email_id,@contact,@password,@time)";
            SqlCommand insertuser = new SqlCommand(inscmd, con);
            insertuser.Parameters.AddWithValue("@name", TextBox1.Text);
            insertuser.Parameters.AddWithValue("@email_id", TextBox2.Text);
            insertuser.Parameters.AddWithValue("@contact", TextBox3.Text);
            insertuser.Parameters.AddWithValue("@password",MyEncrypt( TextBox4.Text));
            insertuser.Parameters.AddWithValue("@time", DateTime.Now.ToString());






            try
            {
                insertuser.ExecuteNonQuery();
                con.Close();
                SendingMail(TextBox2.Text, "technslsuchi@gmail.com", "Techsuchi1@", "You Are Registered", TextBox1.Text);


                //SendingMail(Textbox5.Text, "nslcomp@gmail.com", "Project@123!", " you are registered", Textbox1.Text);
                Response.Redirect("signin.aspx");
                ClientScript.RegisterStartupScript(this.GetType(), "Alert", string.Format("alert('Data Saved Successfully');"), true);
            }
            catch (Exception er)
            {
                Response.Write("something going wrong" + er.Message + "");
            }
            finally
            {

            }
        }
        public string SendingMail(string mailTo, string from, string pass, string subject, string body)
        {

            string msg = string.Empty;
            if (mailTo != "")
            {

                MailMessage message = new MailMessage();
                SmtpClient smtpClient = new SmtpClient();

                try
                {

                    //SendingMail(TextBox3.Text, "nslcomp33@gmail.com", "Sanchit@129!", " you are registered", TextBox1.Text);
                    //Response.Redirect("login.aspx");
                    //ClientScript.RegisterStartupScript(this.GetType(), "Alert", string.Format("alert('Data Saved Successfully');"), true);


                    MailMessage mail = new MailMessage();
                    mail.To.Add(TextBox2.Text.Trim());
                    mail.CC.Add("suchipragya612@gmail.com");
                    mail.From = new MailAddress("technslsuchi@gmail.com");
                    mail.Subject = "Thankyou for registering on our website.";
                    string emailBody = "";
                    emailBody += "<div style='background:#FFFFFF; font-family:Arial,Helvetica,Verdana,sans-serif; font-size:14px; margin:0; padding:0;'>";
                    emailBody += "<table cellspacing='0' cellpadding='0' border='0' width='100%' style='font-family:Arial,Helvetica,Verdana,sans-serif; font-size:14px;'>";
                    emailBody += "<tbody>";
                    emailBody += "<tr>";
                    emailBody += "<td valign='top' style='font-family:Arial,Helvetica,Verdana,sans-serif; font-size:14px;background:#e74c3c;color:#fff;'>";
                    emailBody += "<div style='width:100%;margin-left:auto;margin-right:auto;clear:both;background:#e74c3c;color:#fff;'>";
                    emailBody += "<div style='float:left;width:100%;min-height:35px;font-size:26px;font-weight:bold;text-align:left'>";
                    emailBody += "<div style='clear:both;width:100%;text-align:center;'>&nbsp;&nbsp;&nbsp;Incredible India</div>";
                    emailBody += "<div style='clear:both;width:100%;text-align:center;font-size:11px;font-style:italic;'>&nbsp;&nbsp;&nbsp;&nbsp;Explore Before You Visit!</div>";
                    emailBody += "</div>";
                    emailBody += "</div>";
                    emailBody += "</td>";
                    emailBody += "</tr>";
                    emailBody += "</tbody>";
                    emailBody += "</table>";
                    emailBody += "<table cellspacing='0' cellpadding='0' border='0' width='100%' style='font-family:Arial,Helvetica,Verdana,sans-serif; font-size:14px;margin-left:auto;margin-right:auto;'>";
                    emailBody += "<tbody>";
                    emailBody += "<tr>";
                    emailBody += "<td valign='top' colspan='2' style='width:100%;padding-left:20px;padding-right:20px;font-family:Arial,Helvetica,Verdana,sans-serif; font-size:14px;'>";
                    emailBody += "<p style='font-family:Arial,Helvetica,Verdana,sans-serif; font-size:14px;padding-top:15px;line-height:22px;margin:0px;font-weight:bold;padding-bottom:5px'>Dear " + TextBox1.Text + ",</p>";
                    emailBody += "<p style='font-family:Arial,Helvetica,Verdana,sans-serif; font-size:14px;line-height:22px;color:rgb(41,41,41)'>Your User ID is: " + TextBox2.Text + "</p>";
                    emailBody += "<p style='font-family:Arial,Helvetica,Verdana,sans-serif; font-size:14px;line-height:22px;color:rgb(41,41,41)'>Your Password ID is: " + TextBox3.Text + "</p>";
                    emailBody += "<p>&nbsp;</p><p style='font-family:Arial,Helvetica,Verdana,sans-serif; font-size:14px;line-height:22px;margin:0px'>If you have any additional queries, please feel free to reach out us at +91 6206897118 or drop us an email at <a href='arundhati.rnc18@gmail.com' style='text-decoration:none;font-style:normal;font-variant:normal;font-weight:normal;font-family:Arial,Helvetica,Verdana,sans-serif; font-size:14px;line-height:normal;color:rgb(162,49,35)' target='_blank'>arundhati.rnc18@gmail.com</a>. We are there to help you.</p>";
                    emailBody += "<p>&nbsp;</p>";
                    emailBody += "<p style='font-family:Arial,Helvetica,Verdana,sans-serif; font-size:14px;line-height:22px;margin:0px;font-weight:bold'>Best Regards,</p>";
                    emailBody += "<p style='font-family:Arial,Helvetica,Verdana,sans-serif; font-size:14px;color:rgb(41,41,41);line-height:22px;margin:0px'>Support Team</p>";
                    emailBody += "</td>";
                    emailBody += "</tr>";
                    emailBody += "</tbody>";
                    emailBody += "</table>";
                    emailBody += "</div>";
                    mail.Body = emailBody;
                    mail.IsBodyHtml = true;
                    SmtpClient smtp = new SmtpClient();
                    smtp.Host = "smtp.gmail.com"; //Or Your SMTP Server Address
                    smtp.Port = 587;
                    smtp.Credentials = new System.Net.NetworkCredential("technslsuchi@gmail.com", "Techsuchi1@");
                    smtp.EnableSsl = true;
                    smtp.Send(mail);

                    //SmtpClient smtp = new SmtpClient();
                    //        smtp.Host = "mail.technsl.in"; //Or Your SMTP Server Address
                    //        smtp.Port = 25;
                    //        smtp.Credentials = new System.Net.NetworkCredential("noreply@technsl.in", "2g8c2Mt1Bh");
                    //         your Smtp Email ID and Password
                    //        smtp.EnableSsl = true;
                    //        smtp.Send(mail);

                    Label1.Text = "You are successfully registered to our website. Welcome to Superomart official site.";
                    Label1.ForeColor = System.Drawing.Color.Red;
                }
                catch (Exception ex)
                {
                    throw ex;
                    // msg = ex.Message;
                }
            }
            return msg;
        }
        private string MyEncrypt(string returnText)
        {
            string EncryptionKey = "E6C69AC9CCE39";
            byte[] clearBytes = Encoding.Unicode.GetBytes(returnText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }
                    returnText = Convert.ToBase64String(ms.ToArray());
                }
            }
            return returnText;
        }
        private string MyDecrypt(string returnText)
        {
            string EncryptionKey = "E6C69AC9CCE39";
            byte[] cipherBytes = Convert.FromBase64String(returnText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(cipherBytes, 0, cipherBytes.Length);
                        cs.Close();
                    }
                    returnText = Encoding.Unicode.GetString(ms.ToArray());
                }
            }
            return returnText;
        }
    }
}


