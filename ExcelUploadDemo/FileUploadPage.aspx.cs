﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ExcelDataReader;
using System.Data;

namespace ExcelUploadDemo
{
    public partial class FileUploadPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnUpload_Click(object sender, EventArgs e)
        {
            //Check if the file is an xls file
            if (fileUploadTemplate.HasFile)
            {
                //if the file includes xls then use it
                if (validateTemplate.IsValid)
                {
                    //the file uploaded is valid and begin reading file

                    //read the uploaded excel file
                    IExcelDataReader excelReader = ExcelReaderFactory.CreateOpenXmlReader(fileUploadTemplate.PostedFile.InputStream);
                    DataSet ds = excelReader.AsDataSet();
                    excelReader.Close();

                    System.Data.DataTable dt = ds.Tables[0];

                    //Create a list of strings, each string is a row of data
                    List<String> entryList = new List<string>();

                    int rowCount = dt.Rows.Count;
                    int columnCount = dt.Columns.Count;


                    foreach (DataRow dr in dt.Rows)
                    {
                        //if the student checkbox is selected, only get the tuid and student type
                        if (optStudent.Checked == true)
                        {
                            string entry = dr[0].ToString() + "," + dr[1].ToString();
                            entryList.Add(entry);
                        }


                        //else, that means the PI checkbox is selected, get the tuid and department
                        if (optPI.Checked == true)
                        {
                            string entry = dr[0].ToString() + "," + dr[2].ToString();
                            entryList.Add(entry);
                        }

                    }

                    //once all the data is added to the list 
                    //print the list to a label to show that the data was read
                    string readData = "";

                    //start at 1 since index 0 are the column headers
                    for (int i = 1; i < entryList.ToArray().Length; i++)
                    {
                        readData += entryList.ToArray()[i].ToString() + Environment.NewLine;

                    }


                    txtResult.Text = readData;



                }

                else
                {
                    //the file is not valid/ show error message
                    lblError.Text = "Must upload a valid formatted '.xls' file";
                    lblError.Visible = true;
                }

            }

            //If no file was uploaded then put error message
            else
            {
                lblError.Text = "Must upload a valid formatted '.xls' file";
                lblError.Visible = true;
            }

        }
    }
}