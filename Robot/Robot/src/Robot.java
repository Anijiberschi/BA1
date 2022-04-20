public class Robot {
    
    private String nom;
    private float x,y;
    private String [] listdirection={"Nord","Est","Sud","Ouest"};
    private String direction;

    public Robot(String nom){
        this.nom=nom;
        this.x=0;
        this.y=0;
        this.direction="Est";
    }


    public void avance(){
        if (this.direction =="Est"){
            this.x+=1;
        }
        else if (this.direction =="Nord"){
            this.y+=1;
        }
    }

    public void droite(){

        for (int i=0;i<listdirection.length;i++){
            if (this.direction == this.listdirection[i]){
                this.direction=this.listdirection[(i+1)%4];
            }
        }


    }

    @Override
    public String toString() {
        // TODO Auto-generated method stub
        return "Mon nom est "+this.nom+" mon x est "+this.x+" et y est "+this.y+" et ma direction est"+this.direction;
    }

    public void afficher(){
        System.out.println(toString());
    }
    
    public float getX() {
    	return this.x;
    }
    
    public float getY() {
    	return this.x;
    }
    public String getDirection() {
    	return this.direction;
    }


}
