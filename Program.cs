using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dental_Clinic
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }

        public abstract class User
        {
            private string username;
            private string email;
            private string password;
            private int phoneNumber;

            public User(string username, string email, string password, int phoneNumber)
            {
                this.username = username;
                this.email = email;
                this.password = password;
                this.phoneNumber = phoneNumber;
            }

            public string Username
            {
                get { return username; }
                set { username = value; }
            }

            public string Email
            {
                get { return email; }
                set { email = value; }
            }

            public string Password
            {
                get { return password; }
                set { password = value; }
            }

            public int PhoneNumber
            {
                get { return phoneNumber; }
                set { phoneNumber = value; }
            }

            public virtual string GetUserType()
            {
                return "User";
            }

            public abstract void DisplayDashboard();
            public abstract void Login();
            public abstract void Logout();
        }

        public class Patient : User
        {
            private DateTime dateOfBirth;

            public DateTime DateOfBirth
            {
                get { return dateOfBirth; }
                set { dateOfBirth = value; }
            }

            public Patient(string username, string email, string password, int phoneNumber)
                : base(username, email, password, phoneNumber)
            {
            }
            public override string GetUserType()
            {
                return "Patient";
            }

            public override void DisplayDashboard()
            {
                PatientBoard patientBoard = new PatientBoard();
                patientBoard.Show();
                //MessageBox.Show("Welcome to the Patient Dashboard!");
            }

            public override void Login()
            {
                //login logic for Patient -> fe PatientBoard form
                //MessageBox.Show("Patient logged in successfully!");
            }

            public override void Logout()
            {
                //logout logic for Patient -> fe PatientBoard form
                //MessageBox.Show("Patient logged out successfully!");
            }
        }

        public class Dentist : User
        {
            public Dentist(string username, string email, string password, int phoneNumber)
                : base(username, email, password, phoneNumber)
            {
            }
            public override string GetUserType()
            {
                return "Dentist";
            }

            public override void DisplayDashboard()
            {
                DrBoard drBoard = new DrBoard();
                drBoard.Show();
                //MessageBox.Show("Welcome to the Dentist Dashboard!");
            }

            public override void Login()
            {
                //login logic for Dentist -> fe DrBoard form
                //MessageBox.Show("Dentist logged in successfully!");
            }

            public override void Logout()
            {
                //logout logic for Dentist El katbah fe form DrBoard
                //MessageBox.Show("Dentist logged out successfully!");
            }
        }

        public class Appointment
        {
            public DateTime appointmentDate { get; set; }
            public Patient patientName { get; set; }         //Composotion with Patient class
            public Dentist drName { get; set; }              //Composotion with Dentist class
            public string treatmentType { get; set; } = string.Empty;
            public void ConfirmAppointment()
            {
                //Status = AppointmentStatus.Confirmed;
            }

            public void CancelAppointment()
            {
                //Status = AppointmentStatus.Cancelled;
            }
        }

        public class Treatment
        {
            private string treatmentName { get; set; } = string.Empty;
            private string description { get; set; } = string.Empty;
            private decimal cost { get; set; }

            public Treatment()
            {
                this.treatmentName = "";
                this.description = "";
                this.cost = 0;
            }

            public Treatment(string treatmentName, string description, decimal cost)
            {
                this.treatmentName = treatmentName;
                this.description = description;
                this.cost = cost;
            }

            public string TreatmentName
            {
                get { return treatmentName; }
                set { treatmentName = value; }
            }
            public string Description
            {
                get { return description; }
                set { description = value; }
            }
            public decimal Cost
            {
                get { return cost; }
                set { cost = value; }
            }

            public string GetTreatmentInfo()
            {
                return $"{treatmentName} - ${cost}";
            }

            public decimal CalculateTotalCost(int quantity)
            {
                return cost * quantity;
            }
        }

        public class MedicalHistory
        {
            public List<string> Allergies { get; set; }
            public List<string> Medications { get; set; }
            public List<string> PreviousTreatments { get; set; }
            public string Notes { get; set; }

            public MedicalHistory()
            {
                Allergies = new List<string>();
                Medications = new List<string>();
                PreviousTreatments = new List<string>();
                Notes = "";
            }

            public void AddAllergy(string allergy)
            {
                try
                {
                    if (!string.IsNullOrEmpty(allergy) && !Allergies.Contains(allergy))
                    {
                        Allergies.Add(allergy);
                        Console.WriteLine($"Allergy '{allergy}' added to medical history");
                    }
                }
                catch (Exception ex)
                {
                    throw new DentalClinicException($"Failed to add allergy: {ex.Message}");
                }
            }

            public void AddMedication(string medication)
            {
                try
                {
                    if (!string.IsNullOrEmpty(medication) && !Medications.Contains(medication))
                    {
                        Medications.Add(medication);
                        Console.WriteLine($"Medication '{medication}' added to medical history");
                    }
                }
                catch (Exception ex)
                {
                    throw new DentalClinicException($"Failed to add medication: {ex.Message}");
                }
            }

            public void AddPreviousTreatment(string treatment)
            {
                try
                {
                    if (!string.IsNullOrEmpty(treatment))
                    {
                        PreviousTreatments.Add(treatment);
                        Console.WriteLine($"Previous treatment '{treatment}' added to medical history");
                    }
                }
                catch (Exception ex)
                {
                    throw new DentalClinicException($"Failed to add previous treatment: {ex.Message}");
                }
            }

            public string GetMedicalSummary()
            {
                return $"Allergies: {string.Join(", ", Allergies)}\n" +
                       $"Medications: {string.Join(", ", Medications)}\n" +
                       $"Previous Treatments: {string.Join(", ", PreviousTreatments)}\n" +
                       $"Notes: {Notes}";
            }

            public bool HasAllergies()
            {
                return Allergies.Count > 0;
            }
        }
    }
}

