import java.io.*;

class Nguoi {
	protected String hvt, ns, nn;

	Nguoi() {
	}
}

class KhuPho {
	protected int stv, sn;

	KhuPho() {
	}

	Nguoi tv[];
}

class QL {
	static String nhapgt() throws IOException {
		String str;
		DataInputStream stream = new DataInputStream(System.in);
		str = stream.readLine();
		return str;
	}

	static void nhap(KhuPho kp) throws IOException {
		System.out.print("So nha: ");
		kp.sn = Integer.valueOf(nhapgt()).intValue();
		System.out.print("So thanh vien: ");
		kp.stv = Integer.valueOf(nhapgt()).intValue();
		kp.tv = new Nguoi[kp.stv];
		for (int i = 0; i < kp.stv; i++) {
			System.out.println("Thanh vien thu " + (i + 1));
			kp.tv[i] = new Nguoi();
			System.out.print("Ho ten: ");
			kp.tv[i].hvt = nhapgt();
			System.out.print("Nam sinh: ");
			kp.tv[i].ns = nhapgt();
			System.out.print("Nghe nghiep: ");
			kp.tv[i].nn = nhapgt();
		}
	}

	static void hienthi(KhuPho kp) {
		System.out.println("So thanh vien: " + kp.stv);
		System.out.println("So nha: " + kp.sn);
		for (int i = 0; i < kp.stv; i++) {
			System.out.println("Thanh vien thu " + (i + 1));
			System.out.println("Ho ten: " + kp.tv[i].hvt);
			System.out.println("Nam sinh: " + kp.tv[i].ns);
			System.out.println("Nghe nghiep: " + kp.tv[i].nn);
		}
	}

	public static void main(String args[]) throws IOException {
		int n;
		System.out.print("So ho: ");
		n = Integer.valueOf(nhapgt()).intValue();
		KhuPho KP[] = new KhuPho[n];
		System.out.println("--------NHAP THONG TIN---------");
		for (int j = 0; j < n; j++) {
			System.out.println("Ho thu " + (j + 1));
			KP[j] = new KhuPho();
			nhap(KP[j]);
		}
		System.out.println("----------HIEN THI----------");
		for (int j = 0; j < n; j++) {
			System.out.println("----------------------- ");
			System.out.println("Ho thu " + (j + 1));
			hienthi(KP[j]);
		}
	}
}
