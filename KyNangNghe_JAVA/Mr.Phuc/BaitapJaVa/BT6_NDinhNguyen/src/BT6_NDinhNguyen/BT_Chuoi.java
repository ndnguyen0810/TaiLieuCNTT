package BT6_NDinhNguyen;

import java.util.Map;
import java.util.Scanner;
import java.util.TreeMap;

public class BT_Chuoi {
	public static final char SPACE = ' ';
	public static final char TAB = '\t';
	public static final char BREAK_LINE = '\n';
	public static Scanner sc = new Scanner(System.in);

//Bài 16
//==================================================================================================================
	public static void BT61() {
		System.out.println("Vui lòng nhập chuỗi: ");
		String stringI = sc.nextLine();
		System.out.print("Số từ của chuỗi đã cho là: " + countWords(stringI));
	}

	public static int countWords(String input) {
		if (input == null) {
			return -1;
		}
		int count = 0;
		int size = input.length();
		boolean notCounted = true;
		for (int i = 0; i < size; i++) {
			if (input.charAt(i) != SPACE && input.charAt(i) != TAB && input.charAt(i) != BREAK_LINE) {
				if (notCounted) {
					count++;
					notCounted = false;
				}
			} else {
				notCounted = true;
			}
		}
		return count;
	}
//Bài 17
//==================================================================================================================

	public static void BT17() {
		System.out.println("Vui lòng nhập chuỗi: ");
		String stringI = sc.nextLine();
		System.out.print("Liệt kê số lần xuất hiện của các từ: ");
		Map<String, Integer> wordMap = countWords1(stringI);
		for (String key : wordMap.keySet()) {
			System.out.print(key + " " + wordMap.get(key) + "\n");
		}
	}

	public static void addWord(Map<String, Integer> wordMap, StringBuilder sb) {
		String word = sb.toString();
		if (word.length() == 0) {
			return;
		}
		if (wordMap.containsKey(word)) {
			int count = wordMap.get(word) + 1;
			wordMap.put(word, count);
		} else {
			wordMap.put(word, 1);
		}
	}

	public static Map<String, Integer> countWords1(String input) {
		// khởi tạo wordMap
		Map<String, Integer> wordMap = new TreeMap<String, Integer>();
		if (input == null) {
			return wordMap;
		}
		int size = input.length();
		StringBuilder sb = new StringBuilder();
		for (int i = 0; i < size; i++) {
			if (input.charAt(i) != SPACE && input.charAt(i) != TAB && input.charAt(i) != BREAK_LINE) {
				// build một từ
				sb.append(input.charAt(i));
			} else {
				// thêm từ vào wordMap
				addWord(wordMap, sb);
				sb = new StringBuilder();
			}
		}
		// thêm từ cuối cùng tìm được vào wordMap
		addWord(wordMap, sb);
		return wordMap;
	}

//Bài 18
//==================================================================================================================
	public static void BT18() {
		System.out.println("Vui lòng nhập chuỗi 1: ");
		String str1 = sc.nextLine();
		System.out.println("Vui lòng nhập chuỗi 2: ");
		String str2 = sc.nextLine();
		System.out.println(str1.contains(str2));
	}

//Bài 19
//==================================================================================================================
	public static void BT19() {
		System.out.print("Nhập số phần tử của mảng: ");
		int n = sc.nextInt();
		// khởi tạo arr
		int[] arr = new int[n];
		System.out.println("Nhập các phần tử của mảng: ");
		for (int i = 0; i < n; i++) {
			System.out.printf("a[%d] = ", i);
			arr[i] = sc.nextInt();
		}
		Map<Integer, Integer> map = new TreeMap<Integer, Integer>();
		for (int i = 0; i < n; i++) {
			addElement(map, arr[i]);
		}
		System.out.print("Các phần tử xuất hiện 1 lần: ");
		for (Integer key : map.keySet()) {
			if (map.get(key) == 1) {
				System.out.print(key + " ");
			}
		}
	}

	public static void addElement(Map<Integer, Integer> map, int element) {
		if (map.containsKey(element)) {
			int count = map.get(element) + 1;
			map.put(element, count);
		} else {
			map.put(element, 1);
		}
	}

//Bài 20
//==================================================================================================================
	public static void BT20() {
		System.out.print("Nhập số phần tử của mảng: ");
		int n = sc.nextInt();
		int[] arr = new int[n];
		System.out.println("Nhập các phần tử của mảng: ");
		for (int i = 0; i < n; i++) {
			System.out.printf("a[%d] = ", i);
			arr[i] = sc.nextInt();
		}
		Map<Integer, Integer> map = new TreeMap<Integer, Integer>();
		for (int i = 0; i < n; i++) {
			addElement(map, arr[i]);
		}
		System.out.print("Các phần tử xuất hiện 1 lần: ");
		for (Integer key : map.keySet()) {
			if (map.get(key) == 2) {
				System.out.print(key + " ");
			}
		}
	}

//Bài 21
//==================================================================================================================
	public static void BT21() {
		System.out.print("Nhập số phần tử của mảng: ");
		int n = sc.nextInt();
		// khởi tạo arr
		int[] arr = new int[n];
		System.out.print("Nhập các phần tử của mảng: \n");
		for (int i = 0; i < n; i++) {
			System.out.printf("a[%d] = ", i);
			arr[i] = sc.nextInt();
		}
		Map<Integer, Integer> map = new TreeMap<Integer, Integer>();
		for (int i = 0; i < n; i++) {
			addElement(map, arr[i]);
		}
		System.out.print("Số lần xuất hiện các phần tử: \n");
		for (Integer key : map.keySet()) {
			System.out.printf("%d xuất hiện %d lần.\n", key, map.get(key));
		}
	}

//Bài 22
//==================================================================================================================
	public static void BT22() {
		System.out.print("Nhập số phần tử của mảng: ");
		int n = sc.nextInt();
		// khởi tạo arr
		int[] arr = new int[n];
		System.out.print("Nhập các phần tử của mảng: \n");
		for (int i = 0; i < n; i++) {
			System.out.printf("a[%d] = ", i);
			arr[i] = sc.nextInt();
		}
		// sắp xếp dãy số theo thứ tự tăng dần
		sortASC(arr);
		System.out.println("Dãy số được sắp xếp tăng dần: ");
		show(arr);
	}

	public static void sortASC(int[] arr) {
		int temp = arr[0];
		for (int i = 0; i < arr.length - 1; i++) {
			for (int j = i + 1; j < arr.length; j++) {
				if (arr[i] > arr[j]) {
					temp = arr[j];
					arr[j] = arr[i];
					arr[i] = temp;
				}
			}
		}
	}

	public static void show(int[] arr) {
		for (int i = 0; i < arr.length; i++) {
			System.out.print(arr[i] + " ");
		}
	}

//Bài 23
//==================================================================================================================
	public static void BT23() {
		System.out.print("Nhập số phần tử của mảng: ");
		int n = sc.nextInt();
		// khởi tạo arr
		int[] arr = new int[n];
		System.out.print("Nhập các phần tử của mảng: \n");
		for (int i = 0; i < n; i++) {
			System.out.printf("a[%d] = ", i);
			arr[i] = sc.nextInt();
		}
		// sắp xếp dãy số theo thứ tự giảm dần
		sortDESC(arr);
		System.out.println("Dãy số được sắp xếp giảm dần: ");
		show(arr);
	}

	public static void sortDESC(int[] arr) {
		int temp = arr[0];
		for (int i = 0; i < arr.length - 1; i++) {
			for (int j = i + 1; j < arr.length; j++) {
				if (arr[i] < arr[j]) {
					temp = arr[j];
					arr[j] = arr[i];
					arr[i] = temp;
				}
			}
		}
	}



	public static void main(String[] args) {

	}

}
