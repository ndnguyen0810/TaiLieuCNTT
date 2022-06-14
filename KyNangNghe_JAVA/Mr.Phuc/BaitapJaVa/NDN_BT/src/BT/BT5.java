package BT;

import java.util.Scanner;

public class BT5 {
	public static Scanner scanner = new Scanner(System.in);
	public static void main(String[] args) {
		CandidateManager Cand = new CandidateManager();
		Cand.add();
		Cand.show();
	}
}
