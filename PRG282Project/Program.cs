using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using PRG282Project.Presentation;
using System.IO;
using System.Threading;
using System.Data;
using System.Data.SqlClient;


namespace PRG282Project
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string UserFilePath = @Directory.GetCurrentDirectory() + "/ActiveUsers.txt";
            if (!File.Exists(UserFilePath))
            {
                var fs = File.CreateText(UserFilePath);
                fs.Close();
                StreamWriter sw = new StreamWriter(UserFilePath);
                sw.WriteLine("Admin-Admin-N/A-N/A");
                sw.Close();
            }

            string connect = "Server=localhost;Integrated security=SSPI;database=master";
            SqlConnection sqlconnect = new SqlConnection(connect);
            string datapath = Directory.GetParent(Directory.GetParent(Environment.CurrentDirectory).ToString()).ToString() + @"\Database";
            string Testimage1 = Directory.GetParent(Directory.GetParent(Environment.CurrentDirectory).ToString()).ToString() + @"\TestImages\TestImage1.jpeg";
            string Testimage2 = Directory.GetParent(Directory.GetParent(Environment.CurrentDirectory).ToString()).ToString() + @"\TestImages\TestImage2.jpg";
            string Testimage3 = Directory.GetParent(Directory.GetParent(Environment.CurrentDirectory).ToString()).ToString() + @"\TestImages\TestImage3.jpg";
            string Testimage4 = Directory.GetParent(Directory.GetParent(Environment.CurrentDirectory).ToString()).ToString() + @"\TestImages\TestImage4.jpg";
            String Database;
            String Tables;

            Database =
             "IF NOT EXISTS(SELECT* FROM sys.databases WHERE name = 'DBstudents')" +
             "BEGIN " +
             "CREATE DATABASE DBstudents ON PRIMARY" +
             "(NAME = MyDatabase_Data," +
             "FILENAME = '" + datapath + @"\DBstudentsData.mdf'," +
             "SIZE = 20MB, MAXSIZE = 25MB, FILEGROWTH = 10%)" +
             "LOG ON (NAME = DBStudents_Log," +
             "FILENAME = '" + datapath + @"\DBStudents.ldf'," +
             "SIZE = 5MB," +
             "MAXSIZE = 10MB," +
             "FILEGROWTH = 10%)" +
             "\n" +
             "END ";

            Tables =
             "USE DBstudents \n" +
             "IF NOT EXISTS(SELECT* FROM sysobjects WHERE name = 'tblStudents')" +
             "BEGIN " +
             "CREATE TABLE tblStudents" +
             "(StudentNumber INT PRIMARY KEY IDENTITY(10001,1) NOT NULL," +
             "StundentName NVARCHAR(50)," +
             "StudentSurname NVARCHAR(50)," +
             "StudentImage VARBINARY(MAX)," +
             "DateOfBirth DATE," +
             "Gender NVARCHAR(30)," +
             "PhoneNumber NVARCHAR(50)," +
             "StudentAddress NVARCHAR(MAX),)" +
             "INSERT INTO tblStudents(StundentName, StudentSurname, StudentImage, DateOfBirth, Gender, PhoneNumber, StudentAddress)" +
             "VALUES('Jinny', 'Luckett', (SELECT * FROM OPENROWSET(BULK N'"+Testimage1+"', SINGLE_BLOB) as varbinary) ,'2/18/1987', 'Male', '507-341-7167', '467 Mallory Point')," +
             "('Kayley', 'Alltimes', (SELECT * FROM OPENROWSET(BULK N'"+Testimage2+"', SINGLE_BLOB) as varbinary),'8/24/1996', 'Non-binary', '213-514-2850', '4 Straubel Point')," +
             "('Marcie', 'Kits', null, '8/11/1986', 'Polygender', '913-575-1440', '7 Birchwood Street')," +
             "('Nelia', 'Hale', null, '7/6/1985', 'Non-binary', '350-848-0842', '0971 Loomis Pass')," +
             "('Aymer', 'Angelo', null, '8/5/1991', 'Agender', '171-358-9088', '62305 Lerdahl Road')," +
             "('Anders', 'Merrydew', null, '3/9/1998', 'Genderfluid', '759-860-0785', '7 Forster Point')," +
             "('Winifield', 'McTeer', null, '12/31/1995', 'Genderfluid', '650-431-2085', '80310 Hooker Park')," +
             "('Jacinta', 'Kyneton', null, '12/27/1980', 'Genderqueer', '915-389-1946', '0 Fairfield Hill')," +
             "('Jase', 'Sangar', null, '5/7/1988', 'Genderfluid', '322-245-2691', '6 La Follette Trail')," +
             "('Ariel', 'Badwick', null, '3/12/1990', 'Polygender', '498-183-9874', '62962 Mccormick Hill')," +
             "('Delores', 'Jakubski', null, '4/25/1985', 'Non-binary', '617-178-4037', '831 Macpherson Park')," +
             "('Myron', 'Cossans', (SELECT * FROM OPENROWSET(BULK N'"+Testimage3+"', SINGLE_BLOB) as varbinary), '4/16/1993', 'Genderqueer', '608-321-8893', '72359 Northport Court')," +
             "('Eyde', 'Robrose', (SELECT * FROM OPENROWSET(BULK N'" + Testimage4 + "', SINGLE_BLOB) as varbinary), '6/11/2000', 'Agender', '730-513-2049', '28 Mccormick Terrace')," +
             "('Kippar', 'Schlagh', null, '1/2/1994', 'Genderfluid', '857-196-9652', '92304 School Terrace')," +
             "('Nicki', 'Knowler', null, '8/13/1989', 'Bigender', '384-441-9738', '2526 Weeping Birch Trail')," +
             "('Donnie', 'Frew', null, '10/1/1981', 'Male', '189-101-5269', '902 Hallows Hill')," +
             "('Yehudit', 'Priestnall', null, '7/2/1987', 'Genderqueer', '481-637-9826', '4 Debra Court')," +
             "('Constantina', 'Donoghue', null, '6/24/1990', 'Male', '968-295-0339', '54831 Debs Court')," +
             "('Lena', 'Grix', null, '2/15/1990', 'Male', '655-385-0335', '232 Little Fleur Place')," +
             "('Denys', 'Choake', null, '10/15/1988', 'Genderqueer', '135-102-1183', '31 Glendale Drive')" +
             " END "+

             "IF NOT EXISTS(SELECT* FROM sysobjects WHERE name = 'tblModule')" +
             "BEGIN " +
             "CREATE TABLE tblModule(" +
             "ModuleID INT PRIMARY KEY IDENTITY(1,1)," +
             "ModuleCode NVARCHAR(10) UNIQUE," +
             "ModuleName NVARCHAR(50)," +
             "ModuleDescription NVARCHAR(MAX),)" +
             "INSERT INTO tblModule(ModuleCode, ModuleName, ModuleDescription)" +
             "VALUES('ACW181', 'Academic Writing 181', 'This subject focuses on developing a formal style of writing which will enable the student to communicate complex ideas or concepts within a specialist field.')," +
             "('COA181', 'Computer Architecture 181', 'Students will gain the skills and knowledge necessary to perform various essential tasks on personal computers.')," +
             "('DBD181', 'Database Development 181', 'This module serves as an introduction to database design and development. Database normalization, data integrity')," +
             "('INF181', 'Information Systems 181', 'The purpose of this course is to equip students with the knowledge and competencies to understand Information Technology (IT) as a key enabler of business transformation')," +
             "('LPR181', 'Linear Programming 181', 'Linear Programming is a scientific approach to decision making that seeks to best design and operate a system, under conditions requiring the allocation of scarce resources')," +
             "('MAT181', 'Mathematics 181', 'Mathematics is an understanding of essential mathematical principles, mathematical thinking skills and reasoning')," +
             "('NWD181', 'Networking Development 181', 'This module serves as a general introduction for students to acquire a foundation in current network technologies for local area networks (LANs), wide area networks (WANs), and the Internet')," +
             "('DBD281', 'Database Development 281', 'The student will learn to use the different tools and techniques available for the administration and maintenance of a relational database system')," +
             "('INF281', 'Information Systems 281', 'Information and communication technology has changed the way in which we can access resources and how enterprise applications and software can be accessed')," +
             "('LPR281', 'Linear Programming 281', 'Linear Programming is a scientific approach to decision making that seeks to best design and operate a system, under conditions requiring the allocation of scarce resources')," +
             "('MAT281', 'Mathematics 281', 'This module focuses on developing an understanding of essential mathematical principles, mathematical thinking skills and reasoning')," +
             "('PRG281', 'Programming 281', 'The aim of this course is to introduce the student to the diverse possibilities of professional User Interface Development for desktop applications')," +
             "('PRG282', 'Programming 282', 'In this course the student is expected to integrate all knowledge concerning programming learnt in prerequisite courses and to demonstrate')," +
             "('STA281', 'Statistics 281', 'The overall purpose of the program is to produce graduates that can think clearly and critically and apply the knowledge of Business Statistics in decision making')," +
             "('WPR281', 'Web Programming 281', 'The purpose of the course is to introduce interactive and dynamic web design by incorporating a programming language into a web page')," +
             "('IOT281', 'Internet Of Things 281', 'This course is an introduction to developing and deploying solutions for the Internet of Things (IoT)')," +
             "('SWT281', 'Software Testing 281', 'The main focus of this course is on realistic, pragmatic steps for rigorous and organized software testing')," +
             "('DBD381', 'Database Development 381', 'The aim of the module is to enhance the knowledge of database systems by deepening the understanding of the theoretical and practical aspects of database technologies')," +
             "('LPR381', 'Linear Programming 381', 'Linear Programming is a scientific approach to decision making that seeks to best design and operate a system, under conditions requiring the allocation of scarce resources')," +
             "('MLG381', 'Machine Learning 381', 'Machine learning is a subset of artificial intelligence.')," +
             "('PRJ381', 'Project 381', 'In this module the student is expected to demonstrate the acquired knowledge and skills through the delivery of a project,')," +
             "('PRG381', 'Programming 381', 'The main focus of this module is on providing a comprehensive foundation sufficient for students to create new and/or modify existing applications to meet enterprise real-world requirements')," +
             "('SEN381', 'Software Engineering 381', 'In this module the student is expected to integrate all knowledge concerning programming into a functional project'); " +
             "END " +

             "IF NOT EXISTS(SELECT* FROM sysobjects WHERE name = 'tblBridge')" +
             "BEGIN " +
             "CREATE TABLE tblBridge(" +
             "StudentModuleID INT PRIMARY KEY IDENTITY(1,1)," +
             "StudentNumber INT FOREIGN KEY REFERENCES tblStudents(StudentNumber)," +
             "ModuleID INT FOREIGN KEY REFERENCES tblModule(ModuleID),)" +
             "insert into tblBridge(StudentNumber, ModuleID)" +
             "values(10001, 1)," +
             "(10001, 2)," +
             "(10001, 3)," +
             "(10001, 4)," +
             "(10001, 5)," +
             "(10001, 6)," +
             "(10002, 7)," +
             "(10002, 8)," +
             "(10002, 9)," +
             "(10002, 10)," +
             "(10002, 11)," +
             "(10012, 12)," +
             "(10012, 13)," +
             "(10012, 14)," +
             "(10012, 15)," +
             "(10012, 16)," +
             "(10013, 17)," +
             "(10013, 18)," +
             "(10013, 19)," +
             "(10013, 20)," +
             "(10013, 21)," +
             "(10013, 22)," +
             "(10013, 23); END " +

             "IF NOT EXISTS(SELECT* FROM sysobjects WHERE name = 'tblResources')" +
             "BEGIN " +
             "CREATE TABLE tblResources(" +
             "ResourcesID INT PRIMARY KEY IDENTITY(1,1)," +
             "ModuleID INT FOREIGN KEY REFERENCES tblModule(ModuleID)," +
             "ResouceLink NVARCHAR(MAX),)" +

             "insert into tblResources(ModuleID, ResouceLink)" +
             "values(1, 'http://senate.gov/quam/sapien.jpg?lacinia=eget&nisi=vulputate&venenatis=ut&tristique=ultrices&fusce=vel&congue=augue&diam=vestibulum&id=ante&ornare=ipsum&imperdiet=primis&sapien=in&urna=faucibus&pretium=orci&nisl=luctus&ut=et&volutpat=ultrices&sapien=posuere&arcu=cubilia&sed=curae&augue=donec')," +
             "(2, 'https://tinyurl.com/proin/at/turpis/a/pede.jsp?hac=nulla&habitasse=sed&platea=accumsan&dictumst=felis&etiam=ut&faucibus=at&cursus=dolor&urna=quis&ut=odio&tellus=consequat&nulla=varius&ut=integer&erat=ac&id=leo&mauris=pellentesque&vulputate=ultrices&elementum=mattis&nullam=odio&varius=donec&nulla=vitae&facilisi=nisi&cras=nam&non=ultrices&velit=libero&nec=non&nisi=mattis&vulputate=pulvinar&nonummy=nulla')," +
             "(3, 'https://prweb.com/duis/ac.jsp?orci=vestibulum&pede=ante&venenatis=ipsum&non=primis&sodales=in&sed=faucibus&tincidunt=orci&eu=luctus&felis=et&fusce=ultrices&posuere=posuere&felis=cubilia&sed=curae&lacus=nulla&morbi=dapibus&sem=dolor&mauris=vel&laoreet=est&ut=donec&rhoncus=odio&aliquet=justo&pulvinar=sollicitudin&sed=ut&nisl=suscipit&nunc=a&rhoncus=feugiat&dui=et&vel=eros&sem=vestibulum&sed=ac&sagittis=est&nam=lacinia&congue=nisi&risus=venenatis&semper=tristique&porta=fusce&volutpat=congue&quam=diam&pede=id&lobortis=ornare&ligula=imperdiet&sit=sapien&amet=urna&eleifend=pretium&pede=nisl')," +
             "(4, 'http://technorati.com/convallis/duis/consequat/dui/nec/nisi.jpg?convallis=ligula&nunc=sit&proin=amet&at=eleifend&turpis=pede&a=libero&pede=quis&posuere=orci&nonummy=nullam&integer=molestie&non=nibh&velit=in&donec=lectus&diam=pellentesque&neque=at&vestibulum=nulla&eget=suspendisse&vulputate=potenti&ut=cras&ultrices=in&vel=purus&augue=eu&vestibulum=magna&ante=vulputate&ipsum=luctus&primis=cum&in=sociis&faucibus=natoque&orci=penatibus&luctus=et&et=magnis&ultrices=dis&posuere=parturient&cubilia=montes&curae=nascetur&donec=ridiculus&pharetra=mus&magna=vivamus&vestibulum=vestibulum&aliquet=sagittis&ultrices=sapien&erat=cum&tortor=sociis&sollicitudin=natoque&mi=penatibus&sit=et&amet=magnis&lobortis=dis')," +
             "(5, 'https://google.es/pulvinar/lobortis.jsp?sapien=cras&varius=non&ut=velit&blandit=nec&non=nisi&interdum=vulputate&in=nonummy&ante=maecenas&vestibulum=tincidunt&ante=lacus&ipsum=at&primis=velit&in=vivamus&faucibus=vel&orci=nulla&luctus=eget&et=eros&ultrices=elementum&posuere=pellentesque&cubilia=quisque&curae=porta&duis=volutpat&faucibus=erat&accumsan=quisque&odio=erat&curabitur=eros&convallis=viverra&duis=eget&consequat=congue&dui=eget&nec=semper&nisi=rutrum&volutpat=nulla&eleifend=nunc&donec=purus&ut=phasellus&dolor=in&morbi=felis&vel=donec&lectus=semper&in=sapien&quam=a&fringilla=libero&rhoncus=nam&mauris=dui&enim=proin&leo=leo&rhoncus=odio&sed=porttitor&vestibulum=id&sit=consequat&amet=in&cursus=consequat&id=ut&turpis=nulla&integer=sed&aliquet=accumsan&massa=felis&id=ut&lobortis=at&convallis=dolor&tortor=quis&risus=odio&dapibus=consequat&augue=varius&vel=integer&accumsan=ac&tellus=leo&nisi=pellentesque&eu=ultrices&orci=mattis&mauris=odio&lacinia=donec&sapien=vitae&quis=nisi')," +
             "(6, 'http://spiegel.de/ac/est/lacinia.jpg?vitae=nullam&consectetuer=molestie')," +
             "(7, 'https://hatena.ne.jp/elementum/ligula.js?pulvinar=ac&sed=nulla&nisl=sed&nunc=vel&rhoncus=enim&dui=sit&vel=amet&sem=nunc&sed=viverra&sagittis=dapibus&nam=nulla&congue=suscipit&risus=ligula&semper=in&porta=lacus&volutpat=curabitur&quam=at&pede=ipsum&lobortis=ac&ligula=tellus&sit=semper&amet=interdum&eleifend=mauris&pede=ullamcorper&libero=purus&quis=sit&orci=amet')," +
             "(8, 'http://prnewswire.com/porta/volutpat/quam/pede/lobortis/ligula.jsp?in=rutrum&faucibus=neque&orci=aenean&luctus=auctor&et=gravida&ultrices=sem&posuere=praesent&cubilia=id&curae=massa&duis=id&faucibus=nisl&accumsan=venenatis&odio=lacinia&curabitur=aenean&convallis=sit&duis=amet&consequat=justo&dui=morbi&nec=ut&nisi=odio&volutpat=cras&eleifend=mi&donec=pede&ut=malesuada&dolor=in&morbi=imperdiet&vel=et&lectus=commodo&in=vulputate&quam=justo&fringilla=in&rhoncus=blandit&mauris=ultrices&enim=enim&leo=lorem&rhoncus=ipsum&sed=dolor&vestibulum=sit&sit=amet&amet=consectetuer&cursus=adipiscing&id=elit&turpis=proin&integer=interdum&aliquet=mauris&massa=non&id=ligula&lobortis=pellentesque&convallis=ultrices&tortor=phasellus')," +
             "(9, 'http://constantcontact.com/sapien/iaculis/congue/vivamus/metus/arcu/adipiscing.js?bibendum=et&morbi=ultrices&non=posuere&quam=cubilia&nec=curae&dui=mauris&luctus=viverra&rutrum=diam&nulla=vitae&tellus=quam&in=suspendisse&sagittis=potenti&dui=nullam&vel=porttitor&nisl=lacus&duis=at&ac=turpis&nibh=donec&fusce=posuere&lacus=metus&purus=vitae&aliquet=ipsum&at=aliquam&feugiat=non&non=mauris&pretium=morbi&quis=non&lectus=lectus&suspendisse=aliquam&potenti=sit&in=amet&eleifend=diam&quam=in&a=magna&odio=bibendum&in=imperdiet&hac=nullam&habitasse=orci&platea=pede&dictumst=venenatis&maecenas=non&ut=sodales&massa=sed&quis=tincidunt')," +
             "(10, 'https://blogtalkradio.com/mauris.json?molestie=consequat&hendrerit=in&at=consequat&vulputate=ut&vitae=nulla')," +
             "(11, 'http://nba.com/erat/curabitur/gravida/nisi/at/nibh/in.json?erat=rhoncus&nulla=aliquam&tempus=lacus&vivamus=morbi&in=quis&felis=tortor&eu=id&sapien=nulla&cursus=ultrices&vestibulum=aliquet&proin=maecenas&eu=leo&mi=odio&nulla=condimentum&ac=id&enim=luctus&in=nec&tempor=molestie&turpis=sed&nec=justo&euismod=pellentesque&scelerisque=viverra&quam=pede&turpis=ac&adipiscing=diam&lorem=cras&vitae=pellentesque&mattis=volutpat&nibh=dui&ligula=maecenas&nec=tristique&sem=est&duis=et&aliquam=tempus&convallis=semper&nunc=est&proin=quam&at=pharetra&turpis=magna&a=ac&pede=consequat&posuere=metus&nonummy=sapien&integer=ut&non=nunc&velit=vestibulum&donec=ante&diam=ipsum&neque=primis&vestibulum=in&eget=faucibus&vulputate=orci&ut=luctus&ultrices=et&vel=ultrices&augue=posuere&vestibulum=cubilia&ante=curae&ipsum=mauris&primis=viverra&in=diam&faucibus=vitae')," +
             "(12, 'https://issuu.com/aliquam/lacus/morbi/quis/tortor/id/nulla.json?turpis=sit&integer=amet&aliquet=diam&massa=in&id=magna&lobortis=bibendum&convallis=imperdiet&tortor=nullam&risus=orci&dapibus=pede&augue=venenatis&vel=non&accumsan=sodales&tellus=sed&nisi=tincidunt&eu=eu&orci=felis&mauris=fusce&lacinia=posuere&sapien=felis&quis=sed&libero=lacus&nullam=morbi&sit=sem&amet=mauris&turpis=laoreet&elementum=ut&ligula=rhoncus&vehicula=aliquet&consequat=pulvinar&morbi=sed&a=nisl&ipsum=nunc&integer=rhoncus&a=dui&nibh=vel&in=sem&quis=sed&justo=sagittis&maecenas=nam&rhoncus=congue&aliquam=risus')," +
             "(13, 'http://newyorker.com/odio/consequat/varius/integer.jpg?donec=elementum&dapibus=nullam&duis=varius&at=nulla&velit=facilisi&eu=cras&est=non&congue=velit&elementum=nec&in=nisi&hac=vulputate&habitasse=nonummy&platea=maecenas&dictumst=tincidunt&morbi=lacus&vestibulum=at&velit=velit&id=vivamus&pretium=vel&iaculis=nulla&diam=eget&erat=eros&fermentum=elementum&justo=pellentesque&nec=quisque&condimentum=porta&neque=volutpat&sapien=erat&placerat=quisque&ante=erat&nulla=eros&justo=viverra&aliquam=eget&quis=congue&turpis=eget&eget=semper&elit=rutrum&sodales=nulla&scelerisque=nunc&mauris=purus&sit=phasellus&amet=in&eros=felis&suspendisse=donec&accumsan=semper&tortor=sapien&quis=a&turpis=libero&sed=nam&ante=dui&vivamus=proin&tortor=leo&duis=odio&mattis=porttitor&egestas=id&metus=consequat&aenean=in&fermentum=consequat&donec=ut&ut=nulla&mauris=sed&eget=accumsan&massa=felis&tempor=ut&convallis=at&nulla=dolor&neque=quis&libero=odio&convallis=consequat&eget=varius')," +
             "(14	, 'https://goo.ne.jp/suspendisse/ornare/consequat/lectus/in/est.html?morbi=fermentum&odio=donec&odio=ut&elementum=mauris&eu=eget&interdum=massa&eu=tempor&tincidunt=convallis&in=nulla&leo=neque&maecenas=libero&pulvinar=convallis&lobortis=eget&est=eleifend&phasellus=luctus&sit=ultricies&amet=eu&erat=nibh&nulla=quisque&tempus=id&vivamus=justo&in=sit&felis=amet&eu=sapien&sapien=dignissim&cursus=vestibulum&vestibulum=vestibulum&proin=ante&eu=ipsum&mi=primis&nulla=in&ac=faucibus&enim=orci&in=luctus&tempor=et&turpis=ultrices&nec=posuere&euismod=cubilia&scelerisque=curae&quam=nulla&turpis=dapibus&adipiscing=dolor&lorem=vel&vitae=est&mattis=donec&nibh=odio&ligula=justo&nec=sollicitudin&sem=ut&duis=suscipit&aliquam=a&convallis=feugiat&nunc=et&proin=eros&at=vestibulum&turpis=ac&a=est&pede=lacinia&posuere=nisi&nonummy=venenatis')," +
             "(15, 'http://house.gov/vestibulum/eget/vulputate/ut.js?sapien=felis&quis=sed&libero=interdum&nullam=venenatis&sit=turpis&amet=enim&turpis=blandit&elementum=mi&ligula=in&vehicula=porttitor&consequat=pede&morbi=justo&a=eu&ipsum=massa&integer=donec&a=dapibus&nibh=duis&in=at&quis=velit&justo=eu&maecenas=est&rhoncus=congue&aliquam=elementum&lacus=in&morbi=hac&quis=habitasse&tortor=platea&id=dictumst&nulla=morbi&ultrices=vestibulum&aliquet=velit&maecenas=id&leo=pretium&odio=iaculis&condimentum=diam&id=erat&luctus=fermentum&nec=justo&molestie=nec&sed=condimentum&justo=neque&pellentesque=sapien&viverra=placerat&pede=ante&ac=nulla&diam=justo&cras=aliquam&pellentesque=quis&volutpat=turpis&dui=eget&maecenas=elit&tristique=sodales&est=scelerisque&et=mauris&tempus=sit&semper=amet&est=eros&quam=suspendisse&pharetra=accumsan&magna=tortor&ac=quis&consequat=turpis&metus=sed&sapien=ante&ut=vivamus&nunc=tortor&vestibulum=duis&ante=mattis&ipsum=egestas&primis=metus&in=aenean&faucibus=fermentum&orci=donec&luctus=ut&et=mauris&ultrices=eget&posuere=massa&cubilia=tempor&curae=convallis&mauris=nulla&viverra=neque&diam=libero&vitae=convallis&quam=eget')," +
             "(16, 'https://github.io/vestibulum/ante/ipsum/primis/in.png?tellus=nullam&nisi=orci&eu=pede&orci=venenatis&mauris=non&lacinia=sodales&sapien=sed&quis=tincidunt&libero=eu&nullam=felis&sit=fusce&amet=posuere&turpis=felis&elementum=sed&ligula=lacus&vehicula=morbi&consequat=sem&morbi=mauris&a=laoreet&ipsum=ut&integer=rhoncus&a=aliquet&nibh=pulvinar&in=sed&quis=nisl&justo=nunc&maecenas=rhoncus&rhoncus=dui&aliquam=vel&lacus=sem&morbi=sed&quis=sagittis&tortor=nam&id=congue&nulla=risus&ultrices=semper&aliquet=porta&maecenas=volutpat&leo=quam&odio=pede&condimentum=lobortis&id=ligula&luctus=sit&nec=amet&molestie=eleifend&sed=pede&justo=libero&pellentesque=quis&viverra=orci&pede=nullam&ac=molestie&diam=nibh&cras=in&pellentesque=lectus&volutpat=pellentesque&dui=at&maecenas=nulla&tristique=suspendisse&est=potenti&et=cras&tempus=in&semper=purus&est=eu&quam=magna&pharetra=vulputate&magna=luctus&ac=cum')," +
             "(17, 'https://indiatimes.com/ligula/pellentesque/ultrices.json?ipsum=vestibulum&praesent=ante&blandit=ipsum&lacinia=primis&erat=in&vestibulum=faucibus&sed=orci&magna=luctus&at=et&nunc=ultrices&commodo=posuere&placerat=cubilia&praesent=curae&blandit=duis&nam=faucibus&nulla=accumsan&integer=odio&pede=curabitur&justo=convallis&lacinia=duis&eget=consequat&tincidunt=dui&eget=nec&tempus=nisi&vel=volutpat&pede=eleifend&morbi=donec&porttitor=ut&lorem=dolor&id=morbi&ligula=vel&suspendisse=lectus&ornare=in&consequat=quam&lectus=fringilla&in=rhoncus&est=mauris&risus=enim&auctor=leo&sed=rhoncus&tristique=sed&in=vestibulum&tempus=sit&sit=amet&amet=cursus&sem=id&fusce=turpis&consequat=integer&nulla=aliquet&nisl=massa&nunc=id&nisl=lobortis&duis=convallis&bibendum=tortor&felis=risus&sed=dapibus&interdum=augue&venenatis=vel&turpis=accumsan&enim=tellus&blandit=nisi&mi=eu&in=orci&porttitor=mauris&pede=lacinia&justo=sapien&eu=quis&massa=libero&donec=nullam&dapibus=sit&duis=amet&at=turpis&velit=elementum&eu=ligula&est=vehicula&congue=consequat&elementum=morbi&in=a&hac=ipsum&habitasse=integer&platea=a&dictumst=nibh&morbi=in&vestibulum=quis&velit=justo')," +
             "(18, 'https://google.ru/dui/maecenas/tristique.jpg?elementum=magnis&pellentesque=dis&quisque=parturient&porta=montes&volutpat=nascetur&erat=ridiculus&quisque=mus&erat=etiam&eros=vel&viverra=augue&eget=vestibulum&congue=rutrum&eget=rutrum&semper=neque&rutrum=aenean&nulla=auctor&nunc=gravida&purus=sem&phasellus=praesent&in=id&felis=massa&donec=id&semper=nisl&sapien=venenatis&a=lacinia&libero=aenean&nam=sit&dui=amet&proin=justo&leo=morbi&odio=ut&porttitor=odio&id=cras&consequat=mi&in=pede&consequat=malesuada&ut=in&nulla=imperdiet&sed=et&accumsan=commodo&felis=vulputate&ut=justo&at=in&dolor=blandit&quis=ultrices&odio=enim&consequat=lorem&varius=ipsum&integer=dolor')," +
             "(19, 'http://deliciousdays.com/etiam/justo/etiam/pretium/iaculis/justo/in.json?turpis=pede&sed=posuere&ante=nonummy&vivamus=integer&tortor=non&duis=velit&mattis=donec&egestas=diam&metus=neque&aenean=vestibulum&fermentum=eget&donec=vulputate&ut=ut&mauris=ultrices&eget=vel&massa=augue&tempor=vestibulum&convallis=ante&nulla=ipsum&neque=primis&libero=in&convallis=faucibus&eget=orci&eleifend=luctus&luctus=et&ultricies=ultrices&eu=posuere&nibh=cubilia&quisque=curae&id=donec&justo=pharetra&sit=magna&amet=vestibulum&sapien=aliquet&dignissim=ultrices&vestibulum=erat&vestibulum=tortor&ante=sollicitudin&ipsum=mi&primis=sit&in=amet&faucibus=lobortis&orci=sapien&luctus=sapien&et=non&ultrices=mi&posuere=integer&cubilia=ac&curae=neque&nulla=duis&dapibus=bibendum&dolor=morbi&vel=non&est=quam&donec=nec&odio=dui&justo=luctus&sollicitudin=rutrum&ut=nulla&suscipit=tellus&a=in&feugiat=sagittis&et=dui&eros=vel&vestibulum=nisl&ac=duis&est=ac&lacinia=nibh&nisi=fusce&venenatis=lacus&tristique=purus&fusce=aliquet&congue=at&diam=feugiat&id=non')," +
             "(20, 'http://yellowbook.com/vel/nulla.js?donec=fermentum&semper=justo&sapien=nec&a=condimentum&libero=neque&nam=sapien&dui=placerat&proin=ante&leo=nulla&odio=justo&porttitor=aliquam&id=quis&consequat=turpis&in=eget&consequat=elit&ut=sodales&nulla=scelerisque&sed=mauris&accumsan=sit&felis=amet&ut=eros&at=suspendisse&dolor=accumsan&quis=tortor&odio=quis&consequat=turpis&varius=sed&integer=ante&ac=vivamus&leo=tortor&pellentesque=duis&ultrices=mattis&mattis=egestas&odio=metus&donec=aenean&vitae=fermentum&nisi=donec&nam=ut&ultrices=mauris&libero=eget&non=massa&mattis=tempor&pulvinar=convallis&nulla=nulla&pede=neque&ullamcorper=libero&augue=convallis&a=eget&suscipit=eleifend&nulla=luctus&elit=ultricies&ac=eu&nulla=nibh&sed=quisque&vel=id&enim=justo')," +
             "(21, 'https://skyrock.com/nonummy/maecenas.jpg?elementum=eleifend&ligula=luctus&vehicula=ultricies&consequat=eu&morbi=nibh&a=quisque&ipsum=id&integer=justo&a=sit&nibh=amet&in=sapien&quis=dignissim&justo=vestibulum&maecenas=vestibulum&rhoncus=ante&aliquam=ipsum&lacus=primis&morbi=in&quis=faucibus&tortor=orci&id=luctus&nulla=et&ultrices=ultrices&aliquet=posuere&maecenas=cubilia&leo=curae&odio=nulla&condimentum=dapibus&id=dolor&luctus=vel&nec=est&molestie=donec&sed=odio&justo=justo&pellentesque=sollicitudin&viverra=ut&pede=suscipit&ac=a&diam=feugiat&cras=et&pellentesque=eros&volutpat=vestibulum&dui=ac&maecenas=est&tristique=lacinia&est=nisi&et=venenatis&tempus=tristique&semper=fusce&est=congue&quam=diam&pharetra=id&magna=ornare&ac=imperdiet&consequat=sapien&metus=urna&sapien=pretium&ut=nisl&nunc=ut&vestibulum=volutpat&ante=sapien&ipsum=arcu&primis=sed&in=augue&faucibus=aliquam&orci=erat&luctus=volutpat&et=in&ultrices=congue&posuere=etiam&cubilia=justo&curae=etiam')," +
             "(22, 'http://vk.com/nulla/elit/ac/nulla/sed.js?nulla=eget&eget=eleifend&eros=luctus&elementum=ultricies&pellentesque=eu&quisque=nibh&porta=quisque&volutpat=id&erat=justo&quisque=sit&erat=amet&eros=sapien&viverra=dignissim&eget=vestibulum&congue=vestibulum&eget=ante&semper=ipsum&rutrum=primis&nulla=in&nunc=faucibus&purus=orci&phasellus=luctus&in=et&felis=ultrices&donec=posuere&semper=cubilia&sapien=curae&a=nulla&libero=dapibus&nam=dolor&dui=vel&proin=est&leo=donec&odio=odio&porttitor=justo&id=sollicitudin&consequat=ut&in=suscipit&consequat=a&ut=feugiat&nulla=et&sed=eros&accumsan=vestibulum&felis=ac&ut=est&at=lacinia&dolor=nisi&quis=venenatis&odio=tristique&consequat=fusce&varius=congue&integer=diam&ac=id&leo=ornare&pellentesque=imperdiet&ultrices=sapien&mattis=urna&odio=pretium&donec=nisl&vitae=ut&nisi=volutpat')," +
             "(23, 'http://usatoday.com/hac/habitasse/platea/dictumst/etiam/faucibus.xml?amet=eu&sapien=massa&dignissim=donec&vestibulum=dapibus&vestibulum=duis&ante=at&ipsum=velit&primis=eu&in=est&faucibus=congue&orci=elementum&luctus=in&et=hac&ultrices=habitasse&posuere=platea&cubilia=dictumst&curae=morbi&nulla=vestibulum&dapibus=velit&dolor=id&vel=pretium&est=iaculis&donec=diam&odio=erat&justo=fermentum&sollicitudin=justo&ut=nec&suscipit=condimentum')," +
             "(1, 'https://npr.org/curae/duis.aspx?justo=gravida&maecenas=nisi&rhoncus=at&aliquam=nibh&lacus=in&morbi=hac&quis=habitasse&tortor=platea&id=dictumst&nulla=aliquam&ultrices=augue&aliquet=quam&maecenas=sollicitudin&leo=vitae&odio=consectetuer&condimentum=eget&id=rutrum&luctus=at&nec=lorem&molestie=integer&sed=tincidunt&justo=ante&pellentesque=vel&viverra=ipsum&pede=praesent&ac=blandit&diam=lacinia&cras=erat&pellentesque=vestibulum&volutpat=sed&dui=magna&maecenas=at&tristique=nunc&est=commodo&et=placerat&tempus=praesent&semper=blandit&est=nam&quam=nulla&pharetra=integer&magna=pede&ac=justo&consequat=lacinia&metus=eget&sapien=tincidunt&ut=eget&nunc=tempus&vestibulum=vel&ante=pede&ipsum=morbi&primis=porttitor&in=lorem&faucibus=id&orci=ligula&luctus=suspendisse&et=ornare&ultrices=consequat&posuere=lectus&cubilia=in&curae=est&mauris=risus&viverra=auctor&diam=sed&vitae=tristique&quam=in&suspendisse=tempus&potenti=sit&nullam=amet&porttitor=sem&lacus=fusce&at=consequat&turpis=nulla&donec=nisl&posuere=nunc&metus=nisl&vitae=duis&ipsum=bibendum&aliquam=felis&non=sed&mauris=interdum&morbi=venenatis&non=turpis&lectus=enim&aliquam=blandit&sit=mi&amet=in&diam=porttitor&in=pede&magna=justo&bibendum=eu&imperdiet=massa&nullam=donec&orci=dapibus&pede=duis&venenatis=at')," +
             "(2, 'https://angelfire.com/integer/ac/neque.aspx?sit=fusce&amet=consequat&lobortis=nulla&sapien=nisl&sapien=nunc&non=nisl&mi=duis&integer=bibendum&ac=felis&neque=sed&duis=interdum&bibendum=venenatis&morbi=turpis&non=enim&quam=blandit&nec=mi&dui=in&luctus=porttitor&rutrum=pede&nulla=justo&tellus=eu&in=massa&sagittis=donec&dui=dapibus&vel=duis&nisl=at&duis=velit&ac=eu&nibh=est&fusce=congue&lacus=elementum&purus=in&aliquet=hac&at=habitasse&feugiat=platea&non=dictumst&pretium=morbi&quis=vestibulum&lectus=velit&suspendisse=id&potenti=pretium&in=iaculis&eleifend=diam&quam=erat&a=fermentum&odio=justo&in=nec&hac=condimentum&habitasse=neque&platea=sapien&dictumst=placerat&maecenas=ante&ut=nulla&massa=justo&quis=aliquam&augue=quis&luctus=turpis&tincidunt=eget&nulla=elit&mollis=sodales&molestie=scelerisque&lorem=mauris&quisque=sit&ut=amet&erat=eros&curabitur=suspendisse&gravida=accumsan')," +
             "(4, 'http://utexas.edu/felis.json?amet=odio&diam=consequat&in=varius&magna=integer&bibendum=ac&imperdiet=leo&nullam=pellentesque&orci=ultrices&pede=mattis&venenatis=odio&non=donec&sodales=vitae&sed=nisi&tincidunt=nam&eu=ultrices&felis=libero&fusce=non&posuere=mattis&felis=pulvinar&sed=nulla&lacus=pede&morbi=ullamcorper&sem=augue&mauris=a&laoreet=suscipit&ut=nulla&rhoncus=elit&aliquet=ac&pulvinar=nulla&sed=sed&nisl=vel&nunc=enim&rhoncus=sit&dui=amet&vel=nunc&sem=viverra&sed=dapibus&sagittis=nulla&nam=suscipit')," +
             "(7, 'https://intel.com/tellus/in/sagittis/dui/vel/nisl/duis.png?erat=tincidunt&volutpat=eu&in=felis&congue=fusce&etiam=posuere&justo=felis&etiam=sed&pretium=lacus&iaculis=morbi&justo=sem&in=mauris&hac=laoreet&habitasse=ut&platea=rhoncus&dictumst=aliquet&etiam=pulvinar&faucibus=sed&cursus=nisl&urna=nunc&ut=rhoncus&tellus=dui&nulla=vel&ut=sem&erat=sed&id=sagittis&mauris=nam&vulputate=congue&elementum=risus&nullam=semper&varius=porta&nulla=volutpat&facilisi=quam&cras=pede&non=lobortis&velit=ligula&nec=sit&nisi=amet&vulputate=eleifend&nonummy=pede&maecenas=libero&tincidunt=quis&lacus=orci&at=nullam&velit=molestie&vivamus=nibh&vel=in&nulla=lectus&eget=pellentesque&eros=at&elementum=nulla&pellentesque=suspendisse&quisque=potenti&porta=cras&volutpat=in&erat=purus&quisque=eu&erat=magna&eros=vulputate&viverra=luctus&eget=cum&congue=sociis&eget=natoque&semper=penatibus&rutrum=et')," +
             "(8, 'https://webnode.com/pede/posuere/nonummy.json?nec=massa&nisi=tempor&vulputate=convallis&nonummy=nulla&maecenas=neque&tincidunt=libero&lacus=convallis&at=eget&velit=eleifend&vivamus=luctus&vel=ultricies&nulla=eu&eget=nibh&eros=quisque&elementum=id&pellentesque=justo&quisque=sit&porta=amet&volutpat=sapien&erat=dignissim&quisque=vestibulum&erat=vestibulum&eros=ante&viverra=ipsum&eget=primis&congue=in&eget=faucibus&semper=orci&rutrum=luctus&nulla=et&nunc=ultrices&purus=posuere&phasellus=cubilia&in=curae&felis=nulla&donec=dapibus&semper=dolor&sapien=vel&a=est&libero=donec&nam=odio&dui=justo&proin=sollicitudin&leo=ut&odio=suscipit&porttitor=a&id=feugiat&consequat=et&in=eros&consequat=vestibulum&ut=ac&nulla=est&sed=lacinia&accumsan=nisi&felis=venenatis&ut=tristique&at=fusce')," +
             "(9, 'https://ted.com/erat/fermentum/justo/nec.png?faucibus=sed&orci=sagittis&luctus=nam&et=congue&ultrices=risus&posuere=semper&cubilia=porta&curae=volutpat&nulla=quam&dapibus=pede&dolor=lobortis&vel=ligula&est=sit&donec=amet&odio=eleifend&justo=pede&sollicitudin=libero&ut=quis&suscipit=orci&a=nullam&feugiat=molestie&et=nibh&eros=in&vestibulum=lectus&ac=pellentesque&est=at&lacinia=nulla&nisi=suspendisse&venenatis=potenti&tristique=cras&fusce=in&congue=purus&diam=eu&id=magna&ornare=vulputate&imperdiet=luctus&sapien=cum&urna=sociis&pretium=natoque&nisl=penatibus&ut=et&volutpat=magnis&sapien=dis&arcu=parturient&sed=montes&augue=nascetur&aliquam=ridiculus&erat=mus&volutpat=vivamus&in=vestibulum&congue=sagittis&etiam=sapien&justo=cum&etiam=sociis&pretium=natoque&iaculis=penatibus&justo=et&in=magnis&hac=dis&habitasse=parturient&platea=montes&dictumst=nascetur&etiam=ridiculus&faucibus=mus&cursus=etiam&urna=vel&ut=augue&tellus=vestibulum&nulla=rutrum&ut=rutrum&erat=neque&id=aenean&mauris=auctor&vulputate=gravida&elementum=sem&nullam=praesent&varius=id&nulla=massa&facilisi=id&cras=nisl&non=venenatis&velit=lacinia&nec=aenean&nisi=sit&vulputate=amet&nonummy=justo&maecenas=morbi&tincidunt=ut&lacus=odio&at=cras')," +
             "(10, 'https://goo.gl/morbi.js?eget=elementum&congue=nullam&eget=varius&semper=nulla&rutrum=facilisi&nulla=cras&nunc=non&purus=velit&phasellus=nec&in=nisi&felis=vulputate&donec=nonummy&semper=maecenas&sapien=tincidunt&a=lacus&libero=at&nam=velit&dui=vivamus&proin=vel&leo=nulla&odio=eget&porttitor=eros&id=elementum&consequat=pellentesque&in=quisque&consequat=porta')," +
             "(11, 'http://ed.gov/vestibulum/ante/ipsum/primis/in/faucibus.html?nulla=aliquet&tellus=pulvinar&in=sed&sagittis=nisl&dui=nunc&vel=rhoncus&nisl=dui&duis=vel&ac=sem&nibh=sed&fusce=sagittis&lacus=nam&purus=congue&aliquet=risus&at=semper&feugiat=porta&non=volutpat&pretium=quam&quis=pede&lectus=lobortis&suspendisse=ligula&potenti=sit')," +
             "(12, 'http://google.com/dignissim/vestibulum/vestibulum/ante/ipsum/primis/in.jsp?scelerisque=nulla&quam=ultrices&turpis=aliquet&adipiscing=maecenas&lorem=leo&vitae=odio&mattis=condimentum&nibh=id&ligula=luctus&nec=nec&sem=molestie&duis=sed&aliquam=justo&convallis=pellentesque&nunc=viverra&proin=pede&at=ac&turpis=diam&a=cras&pede=pellentesque&posuere=volutpat&nonummy=dui&integer=maecenas&non=tristique&velit=est&donec=et&diam=tempus&neque=semper&vestibulum=est&eget=quam&vulputate=pharetra&ut=magna&ultrices=ac&vel=consequat&augue=metus&vestibulum=sapien&ante=ut&ipsum=nunc&primis=vestibulum&in=ante&faucibus=ipsum&orci=primis&luctus=in&et=faucibus&ultrices=orci&posuere=luctus')," +
             "(15, 'https://dyndns.org/commodo/placerat/praesent/blandit/nam.aspx?at=luctus&nunc=ultricies&commodo=eu&placerat=nibh&praesent=quisque&blandit=id&nam=justo&nulla=sit&integer=amet&pede=sapien&justo=dignissim&lacinia=vestibulum&eget=vestibulum&tincidunt=ante&eget=ipsum&tempus=primis&vel=in&pede=faucibus&morbi=orci&porttitor=luctus&lorem=et&id=ultrices&ligula=posuere&suspendisse=cubilia&ornare=curae&consequat=nulla&lectus=dapibus&in=dolor&est=vel&risus=est&auctor=donec&sed=odio&tristique=justo&in=sollicitudin&tempus=ut&sit=suscipit&amet=a&sem=feugiat&fusce=et')," +
             "(16, 'http://bbb.org/volutpat/erat/quisque.jsp?in=pellentesque&faucibus=ultrices&orci=phasellus&luctus=id&et=sapien&ultrices=in&posuere=sapien&cubilia=iaculis&curae=congue&duis=vivamus&faucibus=metus&accumsan=arcu&odio=adipiscing&curabitur=molestie&convallis=hendrerit&duis=at&consequat=vulputate&dui=vitae&nec=nisl&nisi=aenean&volutpat=lectus&eleifend=pellentesque&donec=eget&ut=nunc&dolor=donec&morbi=quis&vel=orci&lectus=eget&in=orci&quam=vehicula&fringilla=condimentum&rhoncus=curabitur&mauris=in&enim=libero&leo=ut&rhoncus=massa&sed=volutpat&vestibulum=convallis&sit=morbi&amet=odio&cursus=odio&id=elementum&turpis=eu&integer=interdum&aliquet=eu&massa=tincidunt&id=in&lobortis=leo&convallis=maecenas&tortor=pulvinar&risus=lobortis&dapibus=est&augue=phasellus&vel=sit&accumsan=amet&tellus=erat&nisi=nulla&eu=tempus&orci=vivamus&mauris=in&lacinia=felis&sapien=eu&quis=sapien&libero=cursus&nullam=vestibulum&sit=proin&amet=eu&turpis=mi&elementum=nulla&ligula=ac&vehicula=enim&consequat=in&morbi=tempor&a=turpis&ipsum=nec&integer=euismod&a=scelerisque&nibh=quam&in=turpis&quis=adipiscing&justo=lorem&maecenas=vitae&rhoncus=mattis')," +
             "(17, 'http://scientificamerican.com/vestibulum.png?fusce=morbi&consequat=vel&nulla=lectus&nisl=in&nunc=quam&nisl=fringilla&duis=rhoncus&bibendum=mauris&felis=enim&sed=leo&interdum=rhoncus&venenatis=sed&turpis=vestibulum&enim=sit&blandit=amet&mi=cursus&in=id&porttitor=turpis&pede=integer&justo=aliquet&eu=massa&massa=id&donec=lobortis&dapibus=convallis&duis=tortor&at=risus&velit=dapibus&eu=augue&est=vel&congue=accumsan&elementum=tellus&in=nisi&hac=eu&habitasse=orci&platea=mauris&dictumst=lacinia&morbi=sapien&vestibulum=quis&velit=libero')," +
             "(18, 'http://dedecms.com/sodales.js?aliquet=ipsum&ultrices=primis&erat=in&tortor=faucibus&sollicitudin=orci&mi=luctus&sit=et&amet=ultrices&lobortis=posuere&sapien=cubilia&sapien=curae&non=mauris&mi=viverra&integer=diam&ac=vitae&neque=quam&duis=suspendisse&bibendum=potenti&morbi=nullam&non=porttitor&quam=lacus&nec=at&dui=turpis&luctus=donec&rutrum=posuere&nulla=metus&tellus=vitae&in=ipsum&sagittis=aliquam&dui=non&vel=mauris&nisl=morbi&duis=non&ac=lectus&nibh=aliquam&fusce=sit&lacus=amet&purus=diam&aliquet=in&at=magna&feugiat=bibendum&non=imperdiet&pretium=nullam&quis=orci&lectus=pede&suspendisse=venenatis&potenti=non&in=sodales&eleifend=sed&quam=tincidunt&a=eu&odio=felis&in=fusce&hac=posuere&habitasse=felis&platea=sed&dictumst=lacus&maecenas=morbi&ut=sem&massa=mauris&quis=laoreet&augue=ut&luctus=rhoncus&tincidunt=aliquet&nulla=pulvinar&mollis=sed&molestie=nisl&lorem=nunc&quisque=rhoncus&ut=dui&erat=vel&curabitur=sem&gravida=sed&nisi=sagittis&at=nam&nibh=congue&in=risus&hac=semper&habitasse=porta&platea=volutpat&dictumst=quam&aliquam=pede&augue=lobortis&quam=ligula&sollicitudin=sit&vitae=amet&consectetuer=eleifend&eget=pede')," +
             "(19, 'http://noaa.gov/turpis/a.xml?erat=maecenas&fermentum=pulvinar&justo=lobortis&nec=est&condimentum=phasellus&neque=sit&sapien=amet&placerat=erat&ante=nulla&nulla=tempus&justo=vivamus&aliquam=in&quis=felis&turpis=eu&eget=sapien&elit=cursus&sodales=vestibulum&scelerisque=proin&mauris=eu&sit=mi&amet=nulla&eros=ac&suspendisse=enim&accumsan=in&tortor=tempor&quis=turpis&turpis=nec&sed=euismod&ante=scelerisque&vivamus=quam&tortor=turpis&duis=adipiscing&mattis=lorem&egestas=vitae&metus=mattis&aenean=nibh&fermentum=ligula&donec=nec&ut=sem&mauris=duis&eget=aliquam&massa=convallis&tempor=nunc&convallis=proin&nulla=at&neque=turpis&libero=a&convallis=pede&eget=posuere&eleifend=nonummy&luctus=integer&ultricies=non&eu=velit&nibh=donec&quisque=diam&id=neque&justo=vestibulum&sit=eget&amet=vulputate&sapien=ut&dignissim=ultrices&vestibulum=vel&vestibulum=augue&ante=vestibulum&ipsum=ante&primis=ipsum&in=primis&faucibus=in&orci=faucibus')," +
             "(20, 'https://rambler.ru/ante/vivamus.html?justo=est&sit=lacinia&amet=nisi&sapien=venenatis&dignissim=tristique&vestibulum=fusce&vestibulum=congue&ante=diam&ipsum=id&primis=ornare&in=imperdiet&faucibus=sapien&orci=urna&luctus=pretium&et=nisl&ultrices=ut&posuere=volutpat&cubilia=sapien&curae=arcu&nulla=sed&dapibus=augue&dolor=aliquam&vel=erat&est=volutpat&donec=in&odio=congue&justo=etiam&sollicitudin=justo&ut=etiam&suscipit=pretium&a=iaculis&feugiat=justo&et=in&eros=hac&vestibulum=habitasse&ac=platea&est=dictumst&lacinia=etiam&nisi=faucibus&venenatis=cursus&tristique=urna&fusce=ut&congue=tellus&diam=nulla&id=ut&ornare=erat&imperdiet=id&sapien=mauris&urna=vulputate&pretium=elementum&nisl=nullam&ut=varius&volutpat=nulla&sapien=facilisi&arcu=cras&sed=non')," +
             "(21, 'http://telegraph.co.uk/luctus/tincidunt/nulla/mollis/molestie/lorem.aspx?curabitur=tortor&in=sollicitudin&libero=mi&ut=sit&massa=amet&volutpat=lobortis&convallis=sapien&morbi=sapien&odio=non&odio=mi&elementum=integer&eu=ac&interdum=neque&eu=duis&tincidunt=bibendum&in=morbi')," +
             "(22, 'http://amazon.de/consectetuer/adipiscing/elit.png?tortor=in&quis=faucibus&turpis=orci&sed=luctus&ante=et&vivamus=ultrices&tortor=posuere&duis=cubilia&mattis=curae&egestas=duis&metus=faucibus&aenean=accumsan&fermentum=odio&donec=curabitur&ut=convallis&mauris=duis&eget=consequat&massa=dui&tempor=nec&convallis=nisi&nulla=volutpat&neque=eleifend&libero=donec&convallis=ut&eget=dolor&eleifend=morbi&luctus=vel&ultricies=lectus&eu=in&nibh=quam&quisque=fringilla&id=rhoncus&justo=mauris&sit=enim&amet=leo&sapien=rhoncus&dignissim=sed&vestibulum=vestibulum&vestibulum=sit&ante=amet')," +
             "(23, 'https://ucla.edu/elementum/pellentesque/quisque/porta/volutpat/erat/quisque.json?magna=dictumst&vulputate=maecenas&luctus=ut&cum=massa&sociis=quis&natoque=augue&penatibus=luctus&et=tincidunt&magnis=nulla&dis=mollis&parturient=molestie&montes=lorem');" +
             " END";

            SqlCommand SQLDBCommand = new SqlCommand(Database, sqlconnect);
            SqlCommand SQLTBCommand = new SqlCommand(Tables, sqlconnect);
            try
            {
                sqlconnect.Open();
                SQLDBCommand.ExecuteNonQuery();
                SQLTBCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlconnect.Close();
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}
