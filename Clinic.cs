using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_KazanovAlexandr
{
    public class Clinic { }
    
    public abstract class Doctor
    {
        public virtual void Heal() { }
    }

    public class Surgeon : Doctor
    {
        public override void Heal()
        {
            Console.WriteLine("Surgeon is healing");
        }
    }

    public class Dentist : Doctor
    {
        public override void Heal()
        {
            Console.WriteLine("Dentist is healing");
        }
    }

    public class Therapist : Doctor
    {
        public override void Heal()
        {
            Console.WriteLine("Therapist is healing");
        }
    }

    public class Patient 
    {
        public TreatmentPlan treatmentPlan;
        public Patient(int index) 
        {
            treatmentPlan = new TreatmentPlan(index);
            treatmentPlan.index = index;
        }
        public void Healing()
        {
            if (treatmentPlan.index == 1)
            {
                var doctor = new Surgeon();
                doctor.Heal();
            }
            else if (treatmentPlan.index == 2)
            {
                var doctor = new Dentist();
                doctor.Heal();
            }
            else if (treatmentPlan.index == 3) 
            {
                var doctor = new Therapist();
                doctor.Heal();
            }
            else Console.WriteLine("Can not find treatment plan!");
        }
    }

    public class TreatmentPlan
    {
        public int index { get; set; }
        public TreatmentPlan(int index)
        {
            this.index = index;
        }
    }

}
