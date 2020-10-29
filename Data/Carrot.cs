namespace blazorserver01.Data{
    public class Carrot:Data.BioUnit{
        //base for calling the parents constructor
    
        public Carrot(int x, int y,Data.Environment e): base(x,y,e) 
        {
             this.color = "#fa5511";
            this.living = 0;
            this.livingTop = 3;
        }

        public override bool will_I_live(){
            this.living++;
            if((this.living-1)>=this.livingTop)return false;
            return true;
        }
    }
}