namespace CarExhibition
{
    public abstract class Engin
    {
        public int Volume{get;set;}
        public int Cylanders{get;set;}
        public int HorsePower{get;set;}
        public string Code{get;set;}

        public void Accelerate()
        {
            throw new NotImplementedException();
        }

        public void Start()
        {
            throw new NotImplementedException();
        }
    }

    public class PetrolEngin : Engin
    {
       
    }

    public class DiselEngin : Engin
    {

    }
}