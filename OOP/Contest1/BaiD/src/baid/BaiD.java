/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package baid;

import java.util.AbstractList;
import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

/**
 *
 * @author phi.levan
 */
public class BaiD {

    /**
     * @param args the command line arguments
     */
    
   public void Run(){
       // List<Object> inP = new ArrayList<>();
        Scanner sc = new Scanner(System.in);
        int n = sc.nextInt();
       List<String> result = new ArrayList<>();
        for(int i=0; i<n; i++){
            int m = sc.nextInt();
            List<Object> inP = new ArrayList<>();
            long[] data = new long[m];
             inP.add(m);
            for(int j=0; j<m; j++){
                data[j]=sc.nextLong();
            }
            inP.add(data);
           Processing p = new Processing();
           p.data = inP;
           Thread t =new Thread(p);
           t.start();
           while (p.mess !=null){
               t.stop();
               result.add(p.mess);
           }
        }
        for(int i=0;i<n; i++){
            System.out.println(result.get(i));
        }
        
    }
//   public void process(){
//       List<Object> inP = Nhap();
//       int n =(int) inP.get(0);2
   
//       for(int i=1; i<=n; i++){
//           List<Object> data = (List<Object>)inP.get(i);
//           int m = (int)data.get(0);
//           if(m==1){
//               System.out.println("YES");
//           }
//           else if(m==2){
//               if(data.get(1).toString()==data.get(2).toString()){
//                   System.out.println("YES");
//               }
//               else{
//                   System.out.println("NO");
//               }
//           }
//           else{
//               boolean a=true;
//               for(int j=0; j<m/2;j++){
//                   if(data.get(j).toString()!=data.get(m-j-1).toString()){
//                        a=false;
//                       break;
//                   }
//               }
//               if(a){
//                   System.out.println("YES"); 
//               }
//               else{
//                   System.out.println("NO");
//               }
//           }
//       }
//   }
    public static void main(String[] args) {
        BaiD baiD = new BaiD();
        baiD.Run();
    }
    
}
