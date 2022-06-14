package Menu;

import java.awt.Frame;
import java.awt.MenuItem;
import java.awt.PopupMenu;
import java.awt.event.MouseAdapter;
import java.awt.event.MouseEvent;
import java.awt.event.WindowAdapter;
import java.awt.event.WindowEvent;

public class PopupMenuExample {
	public PopupMenuExample() {
		final Frame frame = new Frame("Ví dụ PopupMenu trong Java AWT");
		final PopupMenu popupmenu = new PopupMenu("Edit");
		MenuItem cut = new MenuItem("Cut");
		cut.setActionCommand("Cut");
		MenuItem copy = new MenuItem("Copy");
		copy.setActionCommand("Copy");
		MenuItem paste = new MenuItem("Paste");
		paste.setActionCommand("Paste");
		popupmenu.add(cut);
		popupmenu.add(copy);
		popupmenu.add(paste);
		frame.addMouseListener(new MouseAdapter() {
			public void mouseClicked(MouseEvent e) {
				popupmenu.show(frame, e.getX(), e.getY());
			}
		});
		frame.add(popupmenu);
		frame.setSize(400, 300);
		frame.setLayout(null);
		frame.setVisible(true);
		frame.addWindowListener(new WindowAdapter() {
			public void windowClosing(WindowEvent e) {
				frame.dispose();
			}
		});
	}

	public static void main(String args[]) {
		new PopupMenuExample();
	}
}