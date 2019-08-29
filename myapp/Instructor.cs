using System;

namespace myapp
{
    public class Instructor
    {
        private float avgFeedback;
        private int experience;
        private string instructorName;
        private string[] instructorSkill;

        public Instructor() {}

        public Instructor(float avgFeedback, int experience, string instructorName, string[] instructorSkill)
        {
            this.AvgFeedback = avgFeedback;
            this.Experience = experience;
            this.InstructorName = instructorName;
            this.InstructorSkill = instructorSkill;
        }

        public float AvgFeedback { get => avgFeedback; set => avgFeedback = value; }
        public int Experience { get => experience; set => experience = value; }
        public string InstructorName { get => instructorName; set => instructorName = value; }
        public string[] InstructorSkill { get => instructorSkill; set => instructorSkill = value; }

        public Boolean checkSkill(string technology) {
            for (int x = 0; x < this.InstructorSkill.Length; x++) {
                if (this.instructorSkill[x].Equals(technology) & this.validateEligibility()) {
                    return true;
                }
            }

            return false;
        }

        public Boolean validateEligibility() {
            if (this.Experience <= 3 && this.AvgFeedback >= 4) {
                return true;
            } else if (this.Experience >= 3 && this.AvgFeedback >= 4.5)  {
                return true;
            }
            return false;
        }

    
    }
}