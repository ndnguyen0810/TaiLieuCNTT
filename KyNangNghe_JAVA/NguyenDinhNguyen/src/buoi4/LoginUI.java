package buoi4;

import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

import javax.swing.*;
import javax.swing.plaf.synth.Region;

public class LoginUI extends JFrame {
	public LoginUI(String title) {
		this.setTitle(title);
		addcontrol();
		addevents();
	}

	JButton btnLogin, btnClose;
	JTextField txtUsername;
	JPasswordField txtJPassword;
	public void addevents() {
		
		btnLogin.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				String user= txtUsername.getText();
				String pass= String.valueOf(txtJPassword.getPassword());				
				if (user.equals("admin")&&pass.equals("admin")) {
					JOptionPane.showMessageDialog(null, "Đăng nhập thành công");
					
				}
				else {
					JOptionPane.showMessageDialog(null, "Thông tin đăng nhập không chính xác");
					System.exit(0);
				}
			}
		});
		
		btnClose.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				System.exit(0);
			}
		});
	}

	
	
	public void addcontrol() {
		Container con = getContentPane();
		JPanel pnBorder=new JPanel();
		con.add(pnBorder);
		
		//top
		pnBorder.setLayout(new BorderLayout());
		JPanel pnNorth=new JPanel();
		JLabel lbltitle= new JLabel("LOGIN");
		pnNorth.add(lbltitle);
		pnBorder.add(pnNorth,BorderLayout.NORTH);
		
		
		JPanel pnWest=new JPanel(new FlowLayout());
		ImageIcon	myImage=new ImageIcon("Image/login.png");
		
		//myImage.getImage().getScaledInstance(10, 10, Image.SCALE_DEFAULT);
		JLabel lbl= new JLabel();
		lbl.setIcon(myImage);
		pnWest.add(lbl);
		pnBorder.add(pnWest,BorderLayout.WEST);
		
			//ben trai
		JPanel pnCenter=new JPanel();
		pnCenter.setLayout(new BoxLayout(pnCenter, BoxLayout.Y_AXIS));		
		
		//user
		JPanel pnUser= new JPanel(new FlowLayout());
		JLabel lblUser= new JLabel("Username: ");
		txtUsername= new JTextField(20);
		pnUser.add(lblUser);
		pnUser.add(txtUsername);
		pnCenter.add(pnUser);
		
		//Pass
		JPanel pnPass= new JPanel(new FlowLayout());
		JLabel lblPass= new JLabel("Password: ");
		txtJPassword= new JPasswordField(20);
		pnPass.add(lblPass);
		pnPass.add(txtJPassword);
		pnCenter.add(pnPass);
		pnBorder.add(pnCenter,BorderLayout.CENTER);

		//button
		JPanel pnSouth=new JPanel();
		btnLogin= new JButton ("Login");
		btnClose= new JButton ("Exit");
		pnSouth.add(btnLogin);
		pnSouth.add(btnClose);
		pnBorder.add(pnSouth,BorderLayout.SOUTH);
		
	}

	public void Show() {
		this.setSize(500, 160);
		this.setDefaultCloseOperation(EXIT_ON_CLOSE);
		this.setLocationRelativeTo(null);
		this.setResizable(false);
		this.setVisible(true);
	}

	public static void main(String[] args) {

		new LoginUI("Nguyễn Đình Nguyên").Show();
	}
}
