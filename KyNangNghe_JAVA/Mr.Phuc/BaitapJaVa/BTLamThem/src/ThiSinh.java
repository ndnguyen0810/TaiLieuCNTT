import java.io.*;

class ThiSinh {
	protected String hvt, dc, ut;
	protected int sbd;

	ThiSinh() {
	}
}

class KhoiA extends ThiSinh {
	protected String Mon1, Mon2, Mon3;

	KhoiA() {
	}

	KhoiA(String m1, String m2, String m3) {
		Mon1 = m1;
		Mon2 = m2;
		Mon3 = m3;
	}
}

class KhoiB extends KhoiA {
	KhoiB() {
	}

	KhoiB(String m1, String m2, String m3) {
		Mon1 = m1;
		Mon2 = m2;
		Mon3 = m3;
	}
}

class KhoiC extends KhoiA {
	KhoiC() {
	}

	KhoiC(String m1, String m2, String m3) {
		Mon1 = m1;
		Mon2 = m2;
		Mon3 = m3;
	}
}

class TuyenSinh {
	static String nhapgt() throws IOException {
		String str;
		DataInputStream stream = new DataInputStream(System.in);
		str = stream.readLine();
		return str;
	}

	static void nhapts(ThiSinh ts) throws IOException {
		System.out.print("SBD: ");
		ts.sbd = Integer.valueOf(nhapgt()).intValue();
		System.out.print("Ho va ten: ");
		ts.hvt = nhapgt();
		System.out.print("Dia chi: ");
		ts.dc = nhapgt();
		System.out.print("Uu tien: ");
		ts.ut = nhapgt();
	}

	static void hienthi(KhoiA ts) {
		System.out.println("--------------------");
		System.out.println("SBD: " + ts.sbd);
		System.out.println("Ho ten: " + ts.hvt);
		System.out.println("Dia chi: " + ts.dc);
		System.out.println("Uu tien: " + ts.ut);
		System.out.println("Mon 1: " + ts.Mon1);
		System.out.println("Mon 2: " + ts.Mon2);
		System.out.println("Mon 3: " + ts.Mon3);
	}

	static boolean ssxau(String s1, String s2) {
		if (s1.equalsIgnoreCase(s2))
			return false;
		else
			return true;
	}

	static int nhaplc() throws IOException {
		String kt;
		System.out.print("Khoi thi: ");
		do {
			kt = nhapgt();
			if (ssxau(kt, "A") && ssxau(kt, "B") && ssxau(kt, "C"))
				System.out.print("Ban chi co the nhap A/B/C: ");
		} while (ssxau(kt, "A") && ssxau(kt, "B") && ssxau(kt, "C"));
		if (ssxau(kt, "A") == false)
			return 1;
		else if (ssxau(kt, "B") == false)
			return 2;
		else if (ssxau(kt, "C") == false)
			return 3;
		else
			return 0;
	}

	public static void main(String args[]) throws IOException {
		int n, a = 0, b = 0, c = 0;
		System.out.print("So luong thi sinh: ");
		n = Integer.valueOf(nhapgt()).intValue();
		KhoiA TSA[] = new KhoiA[n];
		KhoiB TSB[] = new KhoiB[n];
		KhoiC TSC[] = new KhoiC[n];
		System.out.println("--------NHAP THONG TIN---------");
		for (int j = 0; j < n; j++) {
			int lc = nhaplc();
			switch (lc) {
			case 1:
				TSA[a] = new KhoiA("Toan", "Ly", "Hoa");
				nhapts(TSA[a]);
				a++;
				break;
			case 2:
				TSB[b] = new KhoiB("Toan", "Hoa", "Sinh");
				nhapts(TSB[b]);
				b++;
				break;
			case 3:
				TSC[c] = new KhoiC("Van", "Su", "Dia");
				nhapts(TSC[c]);
				c++;
				break;
			default:
				System.out.println();
			}
		}
		System.out.println("----------HIEN THI------------- ");
		for (int j = 0; j < n; j++) {
			if (TSA[j] != null)
				hienthi(TSA[j]);
			if (TSB[j] != null)
				hienthi(TSB[j]);
			if (TSC[j] != null)
				hienthi(TSB[j]);
		}
	}
}
