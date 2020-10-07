    namespace blazorserver01.Data{
    public class Environment{
        private int rows = 1;
        private int cols = 1;
        private BioUnit[,] cell;
        public  Environment(int rows_, int colums_){
            this.rows = rows_;
            this.cols = colums_;
            this.cell = new BioUnit[this.rows,this.cols];
            for(var i=0; i<this.rows; i++)
            for(var j=0; j<this.cols; j++)
            this.cell[i,j] = new BioUnit();
        }
        public int total_of_rows(){
            return this.rows;
        }public int total_of_cols(){
            return this.cols;
        }
        public void live(int i, int j){
            if(this.rightPos(i,j))
                 this.cell[i,j].live();
        }
        public void die(int i, int j){
            if(this.rightPos(i,j))
                 this.cell[i,j].die();
        }
        private bool rightPos(int i, int j){
            return i>=0 && i<this.rows && j>=0 && j<this.cols;
        }
        public bool is_alive(int i, int j){
            if(this.rightPos(i,j))
                return this.cell[i,j].is_alive();
                return false;
        }
    }
}
    
