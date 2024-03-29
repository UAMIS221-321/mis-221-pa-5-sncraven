using System.IO;
namespace mis_221_pa_5_sncraven
{
    public class trainerUtility
    {
        private Trainer[] trainers;

        public trainerUtility(Trainer[] trainers) 
        {
            this.trainers = trainers;
        }
        
        
        public Trainer[] GetAllTrainersFromFile() // displaying Trainer ID, Name, mailing address, and email address
        {
            // open file
            StreamReader inFile = new StreamReader("training.txt");

            Trainer.SetCount(0);
            string line = inFile.ReadLine(); //process the file //priming read 
            while(line != null) 
            {
                string[] temp = line.Split("#");
                trainers[Trainer.GetCount()] = new Trainer(temp[0], int.Parse(temp[1]), temp[2], double.Parse(temp[3]), temp[4]);
                Trainer.IncCount();
                line = inFile.ReadLine(); //update read
            }
            inFile.Close(); //close file 
            return trainers;

        }

        
        public Trainer[] AddTrainer() // adding a trainer to the system
        {
            
            System.Console.WriteLine("Please enter the trainer ID number: ");
            Trainer myTrainer = new Trainer();
            myTrainer.SetTrainerID(int.Parse(Console.ReadLine()));
            System.Console.WriteLine("Please enter the name of the trainer");
            myTrainer.SetTrainerName(Console.ReadLine());
            System.Console.WriteLine("Please enter the trainer's mailing address");
            myTrainer.SetMailingAddress(Console.ReadLine());
            System.Console.WriteLine("Please enter  in the trainer's phone number");
            myTrainer.SetTrainerNumber(double.Parse(Console.ReadLine()));
            System.Console.WriteLine("Please enter the trainer's email address");
            myTrainer.SetTrainerEmailAddress(Console.ReadLine());

            trainers[Trainer.GetCount()] = myTrainer; //putting it in the last available spot in the array
            Trainer.IncCount();
            Trainer.IncMax();
            

            SaveTrainer(); 
            return trainers;
        }
        
        public void SaveTrainer() // saving the added trainer & info of the trainer
        {
            StreamWriter outFile = new StreamWriter("training.txt"); // open file 

            for(int i = 0; i < Trainer.GetCount(); i++) //process the file & priming read 
            {
                outFile.WriteLine(trainers[i].ToFile());
            }
            outFile.Close(); //closing the file 
        }

        private int FindTrainer(int searchVal) //finding a trainer
        {
            for(int i = 0; i < Trainer.GetCount(); i++)
            {
                if(trainers[i].GetTrainerID() == searchVal)
                {
                    return i;
                }
            }
            return -1;
        }
        public Trainer[] UpdateTrainer() //updating the trainer's information 
        {
            System.Console.WriteLine("what is the name of the trainer you would like to update ");
            int searchVal = int.Parse(Console.ReadLine());
            int foundIndex = FindTrainer(searchVal);
            if(foundIndex != -1) 
            {
                System.Console.WriteLine("Please enter the trainer ID number: ");
                trainers[foundIndex].SetTrainerID(int.Parse(Console.ReadLine()));
                System.Console.WriteLine("Please enter the name of the trainer");
                trainers[foundIndex].SetTrainerName(Console.ReadLine());
                System.Console.WriteLine("Please enter the trainer's mailing address");
                trainers[foundIndex].SetMailingAddress(Console.ReadLine());
                System.Console.WriteLine("Please enter in the trainer's phone number");
                trainers[foundIndex].SetTrainerNumber(double.Parse(Console.ReadLine()));
                System.Console.WriteLine("Please enter the trainer's email address");
                trainers[foundIndex].SetTrainerEmailAddress(Console.ReadLine());

                SaveTrainer(); // saving trainer's info to file 
            }
            else 
            {
                System.Console.WriteLine("The trainer was not found");
            }
            return trainers;
        }

        public Trainer[] DeleteTrainer()
        {
            trainers = GetAllTrainersFromFile();
            System.Console.WriteLine("What is the trainer ID of the trainer you want to delete?");
            int searchVal = int.Parse(Console.ReadLine());
            int foundTrainer = FindTrainer(searchVal);
            if(foundTrainer != -1)
            {
                trainers[foundTrainer].SetDeleted(true);
                SaveTrainer();
                trainers = GetAllTrainersFromFile();
                System.Console.WriteLine("The trainer has been deleted");
            }
            else 
            {
                System.Console.WriteLine("The trainer was not found");
            }
            return trainers;
        }

        

        public void Sort() // sorting the trainers in the file 
        {
            for(int i = 0; i < Trainer.GetCount() -1; i++)
            {
                int min = i;
                for(int j = i + 1; j < Trainer.GetCount(); j++)
                {
                    if(trainers[j].GetTrainerName().CompareTo(trainers[min].GetTrainerName()) < 0 || 
                    (trainers[j].GetTrainerName() == trainers[min].GetTrainerName() && trainers[j].GetTrainerID() < trainers[min].GetTrainerID()))
                    {
                        min = j;
                    }
                    if(min != j)
                    {
                        Swap(min,i);
                    }
                }
                
            }
        }
        private void Swap(int x, int y)
        {
            Trainer temp = trainers[x];
            trainers[x] = trainers[y];
            trainers[y] = temp;
        }

    }
}