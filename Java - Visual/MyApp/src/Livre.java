 import java.util.ArrayList;
 
 
 public class Livre
 {
	private String titre;
	private  ArrayList<Page> pages;
	private Couverture couverture;
	
	public Livre(String titre, Couverture couverture){
		this.titre=titre;
		this.couverture=couverture;
		this.pages=new ArrayList<Page>();
	}
	
	public void addPage(Page page){
		pages.add(page); 
	}
	
	
	public int getNbPages(){
		return pages.size();
	}
	
	public Page consulterPage(int indice){
		return pages.get(indice);
	}
	
	public void consulter(){
		System.out.println("Le titre est : "+titre);
		for (int i=0;i<pages.size();i++){
			System.out.println("A la page "+i+" , le titre de la page est "+(pages.get(i)).get_titre());
		}
	}
	
 }