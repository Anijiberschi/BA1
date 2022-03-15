 
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
		return "Le titre de la page est :"+this.titre+" et le contenue de la page est le suivant :"+this.contenue; 
	 }
	 
	 public void consulter(){
		System.out.println("Le titre de la page est "+titre+" et son contenue est le suivant"+contenue);
	 }
 }