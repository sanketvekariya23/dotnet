using System;

namespace hello
{
    class employee
    {
      // public int eid = 50;
      private int eid = 50;    // insted of public to private needs to create getter so that get details from privet so that other class can be access. 

      public double getEId(){    // for access privet element in program.cs
          return eid;
      }
      public string ename = "sanket vekariya";

      //  public void setId(int id){
      //   eid = id;
      // }  
    }
}