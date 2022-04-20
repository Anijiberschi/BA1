
public class RobotNG extends Robot {

	 public RobotNG(String nom) {
		super(nom);
	}

	public void avance(int pas) {
		if (this.getDirection() =="Est"){
            this.getX()+=pas;
        }
        else if (this.getDirection() =="Nord"){
            this.getY()+=1;
        }
	 }
	 
	 public String toString() {
		 return super.toString();
	 }
	
}
