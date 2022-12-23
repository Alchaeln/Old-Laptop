
public class Team {
	// TODO: Declare private fields - teamName, teamWins, teamLosses
	   private String teamName;
	   private int teamWins;
	   private int teamLosses;
	   
	   // TODO: Define mutator methods - 
	   //       setTeamName(), setTeamWins(), setTeamLosses()
	  public void setTeamName(String name){
	     this.teamName = name;
	     }
	  public void setTeamWins(int wins){
	     this.teamWins = wins;
	     }
	  public void setTeamLosses(int losses){
	     this.teamLosses = losses;
	     }
	   
	   // TODO: Define accessor methods - 
	   //       getTeamName(), getTeamWins(), getTeamLosses()
	   
	   public String getTeamName(){
	      return teamName;
	      }
	   public int getTeamWins(){
	      return teamWins;
	      }
	   public int getTeamLosses(){
	      return teamLosses;
	      }
	   
	   public String printMe() {
		return "" + teamWins + " This is war " + teamLosses; 
	   }
	   
	   // TODO: Define getWinPercentage()
	   
	   public double getWinPercentage(){
		 
	      return (teamWins / ((double)teamWins + (double)teamLosses));
	      }
	   
}
