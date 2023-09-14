using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace TheQueue.Model
{
    /// <summary>
    /// <c>Pharmacy</c> models a Pharmacy.
    /// </summary>
    internal class Pharmacy
    {
        private ushort _queueOrder;
        private Queue<Patient> _patients;

        /// <summary>
        /// Constructs a pharmacy with default values.
        /// </summary>
        public Pharmacy()
        {
            QueueOrder = 0;
            Patients = new Queue<Patient>();
        }

        #region Properties
        
        /// <summary>
        /// Contains the last queue number which have been given.
        /// </summary>
        public ushort QueueOrder
        {
            get { return _queueOrder; }
            private set { _queueOrder = value; }
        }

        /// <summary>
        /// Contains a queue of patients.
        /// </summary>
        internal Queue<Patient> Patients
        {
            get { return _patients; }
            private set { _patients = value; }
        }
        #endregion

        /// <summary>
        /// Enqueue a new patient
        /// </summary>
        public string EnqueuePatient(string name)
        {
            QueueOrder++;
            Patients.Enqueue(new Patient(QueueOrder, name));
            return $"Added {FindPatient(QueueOrder)} to the queue";
        }

        /// <summary>
        /// Dequeue Patient
        /// </summary>
        public string DequeuePatient()
        {
            try
            {
                return Patients.Dequeue().ToString() + " left the queue!";
            }
            catch
            {
                return "There are no patients in the queue!";
            }
        }

        /// <summary>
        /// get a string with the number of patients.
        /// </summary>
        /// <returns>string</returns>
        public string NumberOfItems()
        {
            return $"Patients in the queue {Patients.Count}";
        }

        /// <summary>
        /// get a string with the first and last patient.
        /// </summary>
        /// <returns>string</returns>
        public string MinMax()
        {
            try
            {
                int min = Patients.Min(patient => patient.QueueNumber);
                int max = Patients.Max(patient => patient.QueueNumber);
                return $"First Patient ID is: {min} | Last Patient ID is: {max}";
            }
            catch (Exception ex)
            {
                return $"MinMax failed with error message: {ex}";
            }
        }

        /// <summary>
        /// Find a patient in the queue.
        /// </summary>
        /// <param name="queueNumber"></param>
        /// <returns></returns>
        public string FindPatient(int queueNumber)
        {
            try
            {
                return $"{Patients.Where(item => item.QueueNumber == queueNumber).Single()}";
            }
            catch
            {
                return $"Patient{queueNumber} not found!";
            }
        }

        /// <summary>
        /// Print all Patients.
        /// </summary>
        /// <returns></returns>
        public string PatientsToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Patient patient in Patients)
            {
                sb.AppendLine(patient.ToString());
            }
            return sb.ToString();
        }
    }
}
