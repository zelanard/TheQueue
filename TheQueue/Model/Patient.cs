namespace TheQueue.Model
{
    /// <summary>
    /// <c>Patient</c> models a Patient.
    /// </summary>
    internal class Patient
    {
        //Attributes
        private string _name;
        private ushort _queueNumber;

        #region Constructors
        
        /// <summary>
        /// Constructs a patient with a default name.
        /// </summary>
        private Patient()
        {
            Name = "";
        }

        /// <summary>
        /// Constructs a patient with queue number and default name.
        /// </summary>
        /// <param name="number"></param>
        private Patient(ushort number) : this()
        {
            QueueNumber = number;
        }

        /// <summary>
        /// Constructs a patient with queue number and name.
        /// </summary>
        /// <param name="number"></param>
        /// <param name="name"></param>
        public Patient(ushort number, string name) : this(number)
        {
            Name = name;
        }
        #endregion

        #region Properties

        /// <summary>
        /// The name of the patient.
        /// </summary>
        public string Name
        {
            get { 
                return _name; 
            }
            private set
            {
                _name = value;
            }
        }

        /// <summary>
        /// The queue number of the patient.
        /// </summary>
        public ushort QueueNumber
        {
            get { 
                return _queueNumber; 
            }
            private set
            {
                _queueNumber = value;
            }
        }
        #endregion

        //Overrides Object.ToString.
        public override string ToString()
        {
            return $"{Name}: {QueueNumber}";
        }
    }
}
