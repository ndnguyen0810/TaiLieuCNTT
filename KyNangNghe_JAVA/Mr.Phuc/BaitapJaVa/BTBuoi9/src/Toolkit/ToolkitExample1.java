package Toolkit;

import java.awt.Dimension;
import java.awt.Toolkit;

public class ToolkitExample1 {
	public static void main(String[] args) {
		Toolkit t = Toolkit.getDefaultToolkit();
		System.out.println("Độ phân giải màn hình = " + t.getScreenResolution());
		Dimension d = t.getScreenSize();
		System.out.println("Width = " + d.width);
		System.out.println("Height = " + d.height);
	}
}