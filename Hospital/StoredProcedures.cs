﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class StoredProcedures
    {
        //----------------------------Accounts------------------------------
        public static string CreateAccount = "CreateAccount";
        public static string AccountExcist = "AccountExcist";
        public static string IsDoctor = "IsDoctor";
        public static string IsNurse = "IsNurse";
        public static string IsPharma = "IsPharma";
        public static string IsRecept = "IsRecept";
        public static string ChangePassword = "ChangePassword";
        public static string GetOldPassword = "GetOldPassword";
        //-----------------------------Admin--------------------------------
        //Sign Up 
        public static string InsertDoctor = "InsertDoctor";
        public static string InsertReceptionist = "InsertRecepiontist";
        public static string InsertNurse = "InsertNurse";
        public static string InsertPharmacist = "InsertPharmacist";
        //Department
        public static string InsertDepartment = "InsertDepartment";
        public static string DeleteDepartment = "DeleteDepartment";
        public static string GetAllDepartmentNumber = "GetAllDepartmentNumber";
        public static string DepartmentStatistics = "DepartmentStatistics";
        //surgeries
        public static string InsertSurgery = "InsertSurgery";
        //Medical Tests
        public static string InsertMedicalTest = "InsertMedicalTest";
        //Show Employees
        public static string GetAllDep_Doctors = "GetAllDep_Doctors";
        public static string GetAllDoctors = "GetAllDoctors";
        public static string GetAllNurses = "GetAllNurses";
        public static string GetAllPharma = "GetAllPharma";
        public static string GetAllRecept = "GetAllRecept";

        //delete Employees
        public static string DeleteDoctor = "DeleteDoctor";
        public static string DeletePharma = "DeletePharma";
        public static string DeleteNurse = "DeleteNurse";
        public static string DeleteRecept = "DeleteRecept";

        public static string GetDID = "GetDID";
        public static string GetPID = "GetPID";
        public static string GetNID = "GetNID";
        public static string GetDRID = "GetDRID";

        public static string GetDoctorByID = "GetDoctorByID";
        public static string GetNurseByID = "GetNurseByID";
        public static string GetReceptionistByID = "GetReceptionistByID";
        public static string GetPharmaByID = "GetPharmaByID";

        //-----------------------------Doctor--------------------------------
        public static string SelectPatientWithID = "SelectPatientWithID";
        public static string SelectPatientsID = "SelectPatientsID";
        public static string SelectSurgNames = "SelectSurgNames";
        public static string SurgInOperate = "SurgInOperate";
        public static string SelectUpcommingSurgDates = "SelectSurgDates";
        public static string ReserveSurgery = "ReserveSurgery";
        
        public static string CancelSurgery = "CancelSurgery";
        public static string GetNurseIDs = "GetNurseIDs";
        public static string GetRoomsWithNoNurses = "GetRoomsWithNoNurses";
        public static string GetNursesWithNoRooms = "SelectNurseIDsWithNoRooms";
        public static string GetNursesWithRooms = "SelectNurseIDsWithRooms";
        public static string GetRoomsWithNurses = "GetRoomsWithNurses";
        public static string GetRoomOfANurse = "GetRoomOfANurse";
        public static string AssignNurseToRoom = "AssignNurseToRoom";
        public static string RemoveNursefromRoom = "RemoveNursefromRoom";
        public static string GetAllRooms = "GetAllRooms";
        
        public static string DisplayNurseRoomsData = "DisplayNurseRoomsData";

        //--------------------------------Receptionist-----------------------------------
        public static string InsertPatient = "InsertPatient";
        //--------------------------------Pharmacist-------------------------------------
        public static string InsertMedicine = "InsertMedicine";
        public static string GetAllMedicine = "GetAllMedicine";
        public static string GetMedPrice = "GetMedPrice";
        public static string SetMedPrice = "SetMedPrice";
        //-----------------------------------Nurse--------------------------------------
        public static string GetAllMedicalTest = "GetAllMedicalTest";
        public static string GetMedicalTestPrice = "GetMedicalTestPrice";
    }
}
