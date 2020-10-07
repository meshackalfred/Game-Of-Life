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
        public int aliveNeighbors(int i,int j) {
                int c=0;
                c += this.is_alive(i-1,j-1)?1:0;
                c += this.is_alive(i-1,j)?1:0;
                c += this.is_alive(i-1,j+1)?1:0;
                c += this.is_alive(i,j-1)?1:0;
                c += this.is_alive(i,j+1)?1:0;
                c += this.is_alive(i+1,j-1)?1:0;
                c += this.is_alive(i+1,j)?1:0;
                c += this.is_alive(i+1,j+1)?1:0;
                return c;   
         }
         public void nextConwayStep() {
                    int n;
                    bool[,] aux = new bool[this.rows,this.cols];
                    for(var i=0; i<this.rows; i++)
                    for(var j=0; j<this.cols; j++) {
                    n = this.aliveNeighbors(i,j);
                    if(n==3) //Conway’s original rule
                    aux[i,j] = true;
                    else if (n==2 && this.is_alive(i,j))
                    aux[i,j] = true;
                    else
                    aux[i,j] = false;
                    }
                    for(var i=0; i<this.rows; i++)
                    for(var j=0; j<this.cols; j++) {
                    if(aux[i,j])
                    this.live(i,j);
                    else
                    this.die(i,j);
                    }
           }
}
}
    
