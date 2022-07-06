package buoi9.bai1;

import java.awt.*;

import javax.swing.*;

import javax.swing.border.*;
import javax.swing.table.DefaultTableModel;

public class QuanLySanPhamUI extends JFrame {

	private JPanel contentPane;
	private JTable tableTB;
	private JComboBox textField;
	private JTextField txtProductID;
	private JTextField txtProductName;
	private JTextField txtPrice;
	private JTextField txtQuantity;
	private JTextField txtDescription;

	public static void main(String[] args) {
		new QuanLySanPhamUI().Show();
	}

	public void Show() {
		this.setTitle("Nguyen Dinh Nguyen");
		this.setSize(1000, 500);
		this.setDefaultCloseOperation(EXIT_ON_CLOSE);
		this.setLocationRelativeTo(null);
		this.setResizable(false);
		this.setVisible(true);
		setFont(new Font("Times New Roman", Font.PLAIN, 15));
	}
	
	public QuanLySanPhamUI() {
		
		

		contentPane = new JPanel();
		contentPane.setBackground(Color.LIGHT_GRAY);
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		setContentPane(contentPane);
		contentPane.setLayout(new BoxLayout(contentPane, BoxLayout.Y_AXIS));
		
		JMenu mnNewMenu = new JMenu("File");
		contentPane.add(mnNewMenu);
		
		JPanel pnMain = new JPanel();
		contentPane.add(pnMain);
		pnMain.setLayout(new BorderLayout(0, 0));
		
		JPanel pnTitle = new JPanel();
		pnMain.add(pnTitle, BorderLayout.NORTH);
		
		JLabel lbltitle = new JLabel("QUẢN LÝ SẢN PHẨM");
		lbltitle.setForeground(Color.BLUE);
		lbltitle.setFont(new Font("Times New Roman", Font.PLAIN, 29));
		pnTitle.add(lbltitle);
		
		JPanel pnLeft = new JPanel();
		pnMain.add(pnLeft, BorderLayout.WEST);
		pnLeft.setLayout(new BorderLayout(0, 0));
		
		JPanel pnL_list = new JPanel();
		pnLeft.add(pnL_list, BorderLayout.NORTH);
		
		JList list = new JList();
		list.setFont(new Font("Times New Roman", Font.PLAIN, 15));
		pnL_list.add(list);
		
		JPanel pnL_button = new JPanel();
		pnLeft.add(pnL_button, BorderLayout.SOUTH);
//		pnL_list.setBorder(borderInfo);
		
		JButton btnL_New = new JButton("New");
		btnL_New.setFont(new Font("Times New Roman", Font.PLAIN, 15));
		pnL_button.add(btnL_New);
		
		JButton btnL_Update = new JButton("Update");
		btnL_Update.setFont(new Font("Times New Roman", Font.PLAIN, 15));
		pnL_button.add(btnL_Update);
		
		JButton btnL_Remove = new JButton("Remove");
		btnL_Remove.setFont(new Font("Times New Roman", Font.PLAIN, 15));
		pnL_button.add(btnL_Remove);
		
		JPanel pnCenter = new JPanel();
		pnMain.add(pnCenter, BorderLayout.CENTER);
		pnCenter.setLayout(new BoxLayout(pnCenter, BoxLayout.Y_AXIS));
		
		JPanel pnC_Table = new JPanel();
		FlowLayout flowLayout = (FlowLayout) pnC_Table.getLayout();
		pnCenter.add(pnC_Table);
		
		tableTB = new JTable();
		tableTB.setFont(new Font("Times New Roman", Font.PLAIN, 15));
		tableTB.setModel(new DefaultTableModel(
			new Object[][] {
				{null, null, null, null},
				{null, null, null, null},
				{null, null, null, null},
				{null, null, null, null},
				{null, null, null, null},
				{null, null, null, null},
			},
			new String[] {
				"New column", "New column", "New column", "New column"
			}
		));
		pnC_Table.add(tableTB);
		
		JPanel pnC_center = new JPanel();
		pnCenter.add(pnC_center);
		pnC_center.setLayout(new FlowLayout(FlowLayout.CENTER, 5, 5));
		
		JPanel pnCen_Main = new JPanel();
		pnC_center.add(pnCen_Main);
		pnCen_Main.setLayout(new GridLayout(0, 2, 0, 0));
		
		JLabel lblCaterogy = new JLabel("Caterogy:");
		lblCaterogy.setFont(new Font("Times New Roman", Font.BOLD, 15));
		pnCen_Main.add(lblCaterogy);
		
		textField = new JComboBox();
		textField.setFont(new Font("Times New Roman", Font.PLAIN, 15));
		pnCen_Main.add(textField);
		
		JLabel lblProductID = new JLabel("Product ID");
		lblProductID.setFont(new Font("Times New Roman", Font.BOLD, 15));
		pnCen_Main.add(lblProductID);
		
		txtProductID = new JTextField();
		txtProductID.setFont(new Font("Times New Roman", Font.PLAIN, 15));
		txtProductID.setColumns(25);
		pnCen_Main.add(txtProductID);
		
		JLabel lblProductname = new JLabel("Product Name:");
		lblProductname.setFont(new Font("Times New Roman", Font.BOLD, 15));
		pnCen_Main.add(lblProductname);
		
		txtProductName = new JTextField();
		txtProductName.setFont(new Font("Times New Roman", Font.PLAIN, 15));
		txtProductName.setColumns(25);
		pnCen_Main.add(txtProductName);
		
		JLabel lblPrice = new JLabel("Unit Price:");
		lblPrice.setFont(new Font("Times New Roman", Font.BOLD, 15));
		pnCen_Main.add(lblPrice);
		
		txtPrice = new JTextField();
		txtPrice.setFont(new Font("Times New Roman", Font.PLAIN, 15));
		txtPrice.setColumns(25);
		pnCen_Main.add(txtPrice);
		
		JLabel lblQuantity = new JLabel("Quantity:");
		lblQuantity.setFont(new Font("Times New Roman", Font.BOLD, 15));
		pnCen_Main.add(lblQuantity);
		
		txtQuantity = new JTextField();
		txtQuantity.setFont(new Font("Times New Roman", Font.PLAIN, 15));
		txtQuantity.setColumns(25);
		pnCen_Main.add(txtQuantity);
		
		JLabel lblDescription = new JLabel("Description:");
		lblDescription.setFont(new Font("Times New Roman", Font.BOLD, 15));
		pnCen_Main.add(lblDescription);
		
		txtDescription = new JTextField();
		txtDescription.setFont(new Font("Times New Roman", Font.PLAIN, 15));
		txtDescription.setColumns(25);
		pnCen_Main.add(txtDescription);
		
		JPanel pnC_button = new JPanel();
		pnCenter.add(pnC_button);
		
		JButton btnC_New = new JButton("New");
		btnC_New.setFont(new Font("Times New Roman", Font.PLAIN, 15));
		pnC_button.add(btnC_New);
		
		JButton btnC_Save = new JButton("Save");
		btnC_Save.setFont(new Font("Times New Roman", Font.PLAIN, 15));
		pnC_button.add(btnC_Save);
		
		JButton btnC_Remove = new JButton("Remove");
		btnC_Remove.setFont(new Font("Times New Roman", Font.PLAIN, 15));
		pnC_button.add(btnC_Remove);
	}

}
