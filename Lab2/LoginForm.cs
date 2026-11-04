using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Lab2
{
    public partial class LoginForm : Form
    {
        private static Dictionary<string, string> registeredUsers = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        private static readonly string usersFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "users.txt");

        public LoginForm()
        {
            InitializeComponent();
            LoadUsers();
        }

        private void LoadUsers()
        {
            if (File.Exists(usersFilePath))
            {
                string[] lines = File.ReadAllLines(usersFilePath);
                foreach (string line in lines)
                {
                    string[] parts = line.Split(':');
                    if (parts.Length == 2)
                    {
                        registeredUsers[parts[0]] = parts[1];
                    }
                }
            }
        }

        private void SaveUsers()
        {
            List<string> lines = new List<string>();
            foreach (var pair in registeredUsers)
            {
                lines.Add(pair.Key + ":" + pair.Value);
            }
            File.WriteAllLines(usersFilePath, lines);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (username == "" || password == "")
            {
                MessageBox.Show("Username and Password cannot be empty.", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (registeredUsers.ContainsKey(username))
            {
                MessageBox.Show("User '" + username + "' is already registered! Please click Login.", "Already Registered", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            registeredUsers[username] = password;
            SaveUsers();

            MessageBox.Show("Registration successful for '" + username + "'! You can now log in.", "Registered", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (username == "" || password == "")
            {
                MessageBox.Show("Username and Password cannot be empty.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!registeredUsers.ContainsKey(username))
            {
                MessageBox.Show("You are not registered yet! Please click Register first and then Login.", "Not Registered", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (registeredUsers[username] != password)
            {
                MessageBox.Show("Incorrect password! Please try again.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Welcome, " + username + "!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ChooseForm chooseForm = new ChooseForm();
            chooseForm.Show();
            this.Hide();
        }
    }
}

