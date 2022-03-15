 
 public class Page
 {
	String titre;
	String contenue;
	
	
	public Page (String titre,String contenue){
		this.titre=titre;
		this.contenue=contenue;
	}
	
	
	public String get_titre(){
		return titre;
	}

 
	 public String toString()
	 {
		return titre+"\n"+contenue; 
	 }
	 
	 public void consulter(){
		System.out.println(this);
	 }
 }