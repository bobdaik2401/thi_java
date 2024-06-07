/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package domain;
import java.sql.*;
/**
 *
 * @author Administrator
 */
public class dbconnect {
    public Connection open(){
        try {
            Class.forName("com.mysql.cj.jdbc.Driver");
            String conString = "jdbc:mysql://localhost:3306/qlsv";
            Connection cnn = DriverManager.getConnection(conString, "root", "");
            return cnn;
        } catch (Exception e) {
            return null;
        }
    }
}
