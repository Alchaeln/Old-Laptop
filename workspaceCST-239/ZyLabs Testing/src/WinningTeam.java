import java.util.Scanner;

public class WinningTeam {

	public static void main(String[] args) {
		Scanner scnr = new Scanner(System.in);
	      
	      Team team = new Team();
	      
	      String name = "ManASS";
	      int wins = 13;
	      int losses = 3;
	      
	      team.setTeamName(name);
	      team.setTeamWins(wins);
	      team.setTeamLosses(losses);
	      
	      
	      System.out.println(team.printMe());
	      
	      
	      if (team.getWinPercentage() >= 0.5) {
	         System.out.println("Congratulations, Team " + team.getTeamName() +
	                            " has a winning average!");
	      }
	      else {
	         System.out.println("Team " + team.getTeamName() +
	                            " has a losing average.");
	      }
	}

}
