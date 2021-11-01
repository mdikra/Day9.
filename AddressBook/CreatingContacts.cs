using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AddressBook
{
    class CreatingContacts
    {
        private const string V = "";
        string[] AddressData = new string[10];

            int i = 0;
        private object txtFirstName;
        private object txtLastName;
        private object txtAddress;
        private object txtCity;
        private object txtState;
        private object txtZip;
        private object listBox1;
        private object txtSearchText;
        private object listBox1SelectedItem;
        private object listBox1Items;

        public object MessageBox { get; private set; }

        public CreatingContacts()

            {

                InitializeComponent();

            }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        private void btnAdd_Click(object sender, EventArgs e)

            {

                string FirstName = (string)txtFirstName;

                string LastName = (string)txtLastName;

                string Address = (string)txtAddress;

                string City = (string)txtCity;

                string State = (string)txtState;

                string Zip = (string)txtZip;

                string Element = String.Format("{0},{1},{2},{3},{4},{5}", FirstName, LastName, Address, City, State, Zip);

                if (i < 10)

                {

                    AddressData[i] = Element;

                    i++;

                }

                else

                {

                    ListBox1("Addressbook Full!!");

                }

                //Clear TextBoxes

                txtFirstName = "";

                txtLastName = "";

                txtAddress = "";

                txtCity = "";

                txtState = "";

                txtZip = "";

                //Diplay Records in ListBox

                listBox1Clear();

                for (int j = 0; j < 10; j++)

                {

                    if (AddressData[j] != null)

                    {

                        listBox1Add(AddressData[j].ToString().Trim());

                    }

                }


            }

        private void ListBox1(string v)
        {
            throw new NotImplementedException();
        }

        private void listBox1Add(string v)
        {
            throw new NotImplementedException();
        }

        private void listBox1Clear()
        {
            throw new NotImplementedException();
        }

        public object Messagebox(string v)
        {
            throw new NotImplementedException();
        }

        private void btnSearch_Click(object sender, EventArgs e)

            {

                listBox1Clear();

                for (int k = 0; k < AddressData.Length; k++)

                {

                    try

                    {

                        if (AddressData[k].Contains((char)txtSearchText) == true && AddressData[k] != null)

                        {

                            listBox1ItemsAdd(AddressData[k].ToString());

                        }

                    }

                    catch

                    {

                    }

                }

            txtSearchText = V;

            }

        private void listBox1ItemsAdd(string v)
        {
            throw new NotImplementedException();
        }

        private void btnDelete_Click(object sender, EventArgs e)

            {

                for (int k = 0; k < AddressData.Length; k++)

                {

                    try

                    {

                        if (AddressData[k].Contains(listBox1SelectedItem.ToString()))

                        {

                            AddressData[k] = null;

                        }

                    }

                    catch

                    {

                    }

                }

                //Display Refreshed Records in ListBox

                listBox1ItemsClear();

                for (int j = 0; j < 10; j++)

                {

                    if (AddressData[j] != null)

                    {

                        listBox1ItemsAdd(AddressData[j].ToString().Trim());

                    }

                }
            }

        private void listBox1ItemsClear()
        {
            throw new NotImplementedException();
        }

        private void btnClearSearch_Click(object sender, EventArgs e)

            {

                listBox1ItemsClear();

                for (int j = 0; j < 10; j++)

                {

                    if (AddressData[j] != null)

                    {

                        listBox1ItemsAdd(AddressData[j].ToString().Trim());

                    }

                }

            }
        }

    }

