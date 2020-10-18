using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Registery
{
    public partial class formApp : Form
    {
        public formApp()
        {
            InitializeComponent();
        }

        List<Employee> employees = new List<Employee>();

        double sum;

        string success = "Success!";
        string error = "An error has occured.";

        /*Input Validations*/

        //Seller Section
        private Boolean saleRegisterValid()
        {
            if (tbxSellerName.TextLength != 0 && tbxSellerCommission.TextLength != 0 && tbxSellerSales.TextLength != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Consultant Section
        private Boolean shiftRegisterValid()
        {
            if(tbxConsultantName.TextLength != 0 && tbxConsultantRate.TextLength != 0 && tbxConsultantHours.TextLength != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Clerk Section
        private Boolean salaryRegisterValid()
        {
            if(tbxClerkName.TextLength != 0 && tbxClerkSalary.TextLength != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void updateRegistery()
        {
            lbxRegistery.Items.Clear();
            foreach (Employee employee in employees)
            {
                lbxRegistery.Items.Add(employee);
            }
        }

        private void updateSalaries()
        {
            lbxSalaries.Items.Clear();
            foreach (Employee employee in employees)
            {
                lbxSalaries.Items.Add(employee.ToString() + ": " + employee.calculateSalary());
            }
        }

        private void btnRegisterSale_Click(object sender, EventArgs e)
        {
            if(saleRegisterValid())
            {
                Seller seller = new Seller(tbxSellerName.Text, double.Parse(tbxSellerCommission.Text), double.Parse(tbxSellerSales.Text));
                employees.Add(seller);
                updateRegistery();
                updateSalaries();
                MessageBox.Show(success);
                tbxSellerName.Text = null;
                tbxSellerCommission.Text = null;
                tbxSellerSales.Text = null;
            }
            else
            {
                MessageBox.Show(error);
            }
        }

        private void btnRegsiterShift_Click(object sender, EventArgs e)
        {
            if(shiftRegisterValid())
            {
                Consultant consultant = new Consultant(tbxConsultantName.Text, double.Parse(tbxConsultantRate.Text), double.Parse(tbxConsultantHours.Text));
                employees.Add(consultant);
                updateRegistery();
                updateSalaries();
                MessageBox.Show(success);
                tbxConsultantName.Text = null;
                tbxConsultantRate.Text = null;
                tbxConsultantHours.Text = null;
            }
            else
            {
                MessageBox.Show(error);
            }
        }

        private void btnRegisterSalary_Click(object sender, EventArgs e)
        {
            if(salaryRegisterValid())
            {
                Clerk clerk = new Clerk(tbxClerkName.Text, double.Parse(tbxClerkSalary.Text));
                employees.Add(clerk);
                updateRegistery();
                updateSalaries();
                MessageBox.Show(success);
                tbxClerkName.Text = null;
                tbxClerkSalary.Text = null;
            }
            else
            {
                MessageBox.Show(error);
            }
        }

        private void btnCalculateSalaries_Click(object sender, EventArgs e)
        {
            tbxTotalSalaries.Text = null;
            foreach (Employee employee in employees)
            {
                sum += employee.calculateSalary();
            }

            tbxTotalSalaries.Text = "" + sum;
        }
    }
}
