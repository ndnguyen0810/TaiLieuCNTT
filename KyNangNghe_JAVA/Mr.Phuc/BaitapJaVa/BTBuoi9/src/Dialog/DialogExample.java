package Dialog;

import java.awt.Button;
import java.awt.Dialog;
import java.awt.FlowLayout;
import java.awt.Frame;
import java.awt.Label;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.awt.event.WindowAdapter;
import java.awt.event.WindowEvent;

public class DialogExample {
	private static Dialog dialog;

	public DialogExample() {
		Frame frame = new Frame();
		dialog = new Dialog(frame, "Ví dụ Dialog trong Java AWT", true);
		dialog.setLayout(new FlowLayout());
		Button button = new Button("Close");
		button.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				DialogExample.dialog.setVisible(false);
			}
		});
		dialog.add(new Label("Click button to close dialog."));
		dialog.add(button);
		dialog.setSize(300, 300);
		dialog.setVisible(true);
		frame.addWindowListener(new WindowAdapter() {
            public void windowClosing(WindowEvent e) {
            	frame.dispose();
            }
        });
	}

	public static void main(String args[]) {
		new DialogExample();
	}
}
