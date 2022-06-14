package Menu;

import java.awt.Frame;
import java.awt.Menu;
import java.awt.MenuBar;
import java.awt.MenuItem;
import java.awt.event.WindowAdapter;
import java.awt.event.WindowEvent;

public class MenuItemExample {
	public MenuItemExample() {
		Frame frame = new Frame("Ví dụ Menu và MenuItem trong Java AWT");
		MenuBar menuBar = new MenuBar();
		Menu menu = new Menu("Menu");
		Menu submenu = new Menu("Sub Menu");
		MenuItem menuItem1 = new MenuItem("Item 1");
		MenuItem menuItem2 = new MenuItem("Item 2");
		MenuItem menuItem3 = new MenuItem("Item 3");
		MenuItem menuItem4 = new MenuItem("Item 4");
		MenuItem menuItem5 = new MenuItem("Item 5");
		menu.add(menuItem1);
		menu.add(menuItem2);
		menu.add(menuItem3);
		submenu.add(menuItem4);
		submenu.add(menuItem5);
		menu.add(submenu);
		menuBar.add(menu);
		frame.setMenuBar(menuBar);
		frame.setSize(450, 250);
		frame.setLayout(null);
		frame.setVisible(true);
		frame.addWindowListener(new WindowAdapter() {
            public void windowClosing(WindowEvent e) {
            	frame.dispose();
            }
        });
	}

	public static void main(String args[]) {
		new MenuItemExample();
	}
}