namespace blazorserver01.Data
{
    public class Rabbit:Data.BioUnit
    {
        //base for calling the parents constructor
     private int hungry;
     private int hungryTop;

      public int living;
        public int livingTop;

        public Rabbit(int x, int y, Environment e): base(x,y, e)
        { 
            this.color = "#fafafa";
            this.living = 0;
            this.livingTop = 6;
        }
        public override bool will_I_live(){
            this.hungry++;
            this.living++;
            if((this.living-1)>=this.livingTop) return false;
            if((this.hungry-1)>=this.hungryTop) return false;
            return true;
        }

        public void eat(){
            this.hungry = 0;
        }
    }
}