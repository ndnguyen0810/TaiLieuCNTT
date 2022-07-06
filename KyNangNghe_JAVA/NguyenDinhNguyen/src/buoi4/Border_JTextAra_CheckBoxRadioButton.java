package buoi4;

import java.awt.event.*;
import java.awt.*;
import javax.swing.*;
import javax.swing.border.*;


public class Border_JTextAra_CheckBoxRadioButton extends JFrame{
	JTextField txtTen;
	JTextArea areaDiachi;
	JButton btnOK;
	JRadioButton rdNam ,rdNu; 
	JCheckBox cbST1,cbST2;


	public Border_JTextAra_CheckBoxRadioButton(String title) {
		this.setTitle(title);
		addControl();
		addEvents();
	}


	
	public void addEvents() {
		btnOK.addActionListener(new ActionListener() {
			
			@Override
			public void actionPerformed(ActionEvent e) {
				// TODO Auto-generated method stub
				String name = txtTen.getText();
				String address=areaDiachi.getText();
				String GT ="";
				String ST = "";
				if(rdNam.isSelected()) {
					GT = rdNam.getText();
				}else
				if(rdNu.isSelected()) {
					GT = rdNu.getText();	
				}
				if(cbST1.isSelected()) {
					ST += cbST1.getText() +'\n';
	 			}
				if(cbST2.isSelected()) {
					ST += cbST2.getText() +'\n';
	 			}
		        JOptionPane.showMessageDialog(null,name +"\n"+ address +"\n" +ST  +GT);
		        
		}});
		
	}
	
	public void addControl() {
		Container con = getContentPane();
		
		JPanel pnMain = new JPanel();
		pnMain.setLayout(new GridLayout(3,1));
		
		JPanel pnInfo = new JPanel();
		pnInfo.setLayout(new FlowLayout());
		Border borderInfo = BorderFactory.createLineBorder(Color.BLUE);
		TitledBorder titteInfo = BorderFactory.createTitledBorder(borderInfo,"Thông tin");
		pnInfo.setBorder(titteInfo);

		JPanel pnTen = new JPanel();
		pnTen.setLayout(new FlowLayout());
		JLabel lblTen = new JLabel("Nhập tên :");
		lblTen.setSize(150,150);
		txtTen = new JTextField(15);
		pnTen.add(lblTen);
		pnTen.add(txtTen);
		pnInfo.add(pnTen);
		
		JPanel pnDiachi = new JPanel();
		pnDiachi.setLayout(new FlowLayout());
		JLabel lblDiachi = new JLabel("Địa chỉ:");
		lblDiachi.setSize(150,150);
		areaDiachi= new JTextArea(5,15);
		JScrollPane scDiaChi = new JScrollPane(areaDiachi,JScrollPane.VERTICAL_SCROLLBAR_ALWAYS,JScrollPane.HORIZONTAL_SCROLLBAR_ALWAYS);
		pnDiachi.add(lblDiachi);
		pnDiachi.add(scDiaChi);
		pnInfo.add(pnDiachi);
		
		JPanel pnChoice = new JPanel();
		pnChoice.setLayout(new GridLayout(1,2));
		
		JPanel pnSothich = new JPanel();
		Border borderSothich = BorderFactory.createLineBorder(Color.RED);
		TitledBorder titteSothich = BorderFactory.createTitledBorder(borderSothich,"Sở thích");
		pnSothich.setBorder(titteSothich);
		
		JPanel cbSoThich= new JPanel();
		cbSoThich.setLayout(new GridLayout(2,1));
		cbST1= new JCheckBox("Đi bơi");
		cbST2= new JCheckBox("Đi xem phim");
		cbSoThich.add(cbST1);
		cbSoThich.add(cbST2);
		pnSothich.add(cbSoThich);

		JPanel pnGT = new JPanel();
		Border borderGT = BorderFactory.createLineBorder(Color.RED);
		TitledBorder titteGT = BorderFactory.createTitledBorder(borderGT,"Giới tính");
		pnGT.setBorder(titteGT);
		pnGT.setLayout(new BoxLayout(pnGT,BoxLayout.Y_AXIS));
		rdNam = new JRadioButton("Nam");
		rdNu = new JRadioButton("Nữ");
		ButtonGroup grpGT = new ButtonGroup();
		grpGT.add(rdNam);
		grpGT.add(rdNu);
		pnGT.add(rdNam);
		pnGT.add(rdNu);

		JPanel pnAction = new JPanel();
		pnAction.setLayout(new BorderLayout());
		JPanel pnOK = new JPanel();
		btnOK = new JButton("OK");
		pnOK.add(btnOK);
		pnAction.add(pnOK,BorderLayout.EAST);
		
		pnChoice.add(pnSothich);
		pnChoice.add(pnGT);

		pnMain.add(pnInfo);
		pnMain.add(pnChoice);
		pnMain.add(pnAction);

		con.add(pnMain);

		
	}
	
	public void ShowWindow() {
		this.setSize(600, 600);
		this.setDefaultCloseOperation(EXIT_ON_CLOSE);
		this.setLocationRelativeTo(null);
		this.setResizable(false);
		this.setVisible(true);
	}


	
public static void main(String[] args) {
	new Border_JTextAra_CheckBoxRadioButton("Nguyen Dinh Nguyen").ShowWindow();
}
}
