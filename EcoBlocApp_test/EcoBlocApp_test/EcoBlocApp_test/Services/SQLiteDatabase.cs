using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using SQLite;
using System.Linq;
using EcoBlocApp_test.Models;
using SQLiteNetExtensions.Extensions;

namespace EcoBlocApp_test.Services
{
    public class SQLiteDatabase
    {
        private SQLiteConnection _database;

        public SQLiteDatabase()
        {
            var path = GetDbPath();
            _database = new SQLiteConnection(path);

            _database.CreateTable<Event>();
            _database.CreateTable<ClosedDumpsite>();
            _database.CreateTable<EventMarker>();
            _database.CreateTable<Participant>();
            _database.CreateTable<OpenDumpsite>();
            _database.CreateTable<DumpsiteMarker>();
            _database.CreateTable<PendingEvent>();
            _database.CreateTable<ReportedDumpsite>();
            _database.CreateTable<SiteInformation>();
            _database.CreateTable<TempDumpsite>();
            _database.CreateTable<TempDumpsiteMarker>();
            
            SeedDatabase();
            

        }

        public string GetDbPath()
        {
            var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "ecobloc.db");

            return path;
        }

        public void SeedDatabase()
        {
            if(_database.Table<SiteInformation>().Count() == 0)
            {
                var site = new SiteInformation();
                site.Name = "Test Site 1";
                site.ImageUrl = "1"; //get image
                site.About = "This is a test site";
                site.Address = "123 Test Road";
                site.WebsiteLink = "www.TestSite.com";
                site.PhoneNumber = 1234567890;
                site.PinLabel = "Test Site 1";
                site.PinAddress = "123 Test Road";
                site.Latitude = -34.031330M;
                site.Longitude = 18.589440M;

                _database.Insert(site);

                var site2 = new SiteInformation();
                site2.Name = "Test Site 2";
                site2.ImageUrl = "1";
                site2.About = "This is a test site";
                site2.Address = "123 Test Road";
                site2.WebsiteLink = "www.TestSite.com";
                site2.PhoneNumber = 1234567890;
                site2.PinLabel = "Test Site 2";
                site2.PinAddress = "123 Test Road";
                site2.Latitude = -34.031360M;
                site2.Longitude = 18.589450M;

                _database.Insert(site2);

                var site3 = new SiteInformation();
                site3.Name = "Test Site 3";
                site3.ImageUrl = "1";
                site3.About = "This is a test site";
                site3.Address = "123 Test Road";
                site3.WebsiteLink = "www.TestSite.com";
                site3.PhoneNumber = 1234567890;
                site3.PinLabel = "Test Site 3";
                site3.PinAddress = "123 Test Road";
                site3.Latitude = -34.031390M;
                site3.Longitude = 18.589470M;

                _database.Insert(site3);
            }

            if (_database.Table<Event>().Count() == 0)
            { 
                var seedevent = new Event();//
                seedevent.EventDate = DateTime.Now;
                seedevent.ReasonForCreation = "Test Event";
                seedevent.NameOfEvent = "Test Event";



                var seedopendumpsite = new ClosedDumpsite();//
                seedopendumpsite.WasteTypes = "Litter";
                seedopendumpsite.StreetName = "123 Test Street";
                seedopendumpsite.ImageUrl = "1";
                seedopendumpsite.Comment = "Testing 123!";


                seedevent.EventDumpsite = seedopendumpsite;
                _database.Insert(seedevent);
                _database.UpdateWithChildren(seedevent);


                var seedeventmarker = new EventMarker();//
                seedeventmarker.PinAddress = "123 Test Road";
                seedeventmarker.PinLabel = "Event Pin";
                seedeventmarker.Latitude = -34.031400M;
                seedeventmarker.Longitude = 18.589480M;

                seedopendumpsite.EventMarker = seedeventmarker;

                _database.Insert(seedeventmarker);
                _database.Insert(seedopendumpsite);
                _database.UpdateWithChildren(seedopendumpsite);

                var seedparticipant1 = new Participant();//
                seedparticipant1.Name = "Test Person 1";
                seedparticipant1.ContactDetails = 1234567890;
                seedparticipant1.ReasonForJoining = "Testing the Event";
                seedparticipant1.Contribution = "Nothing";

                seedevent.AddParticipant(seedparticipant1);

                _database.Insert(seedparticipant1);

                var seedparticipant2 = new Participant();//
                seedparticipant2.Name = "Test Person 2";
                seedparticipant2.ContactDetails = 1234567890;
                seedparticipant2.ReasonForJoining = "Testing the Event";
                seedparticipant2.Contribution = "Nothing";

                seedevent.AddParticipant(seedparticipant2);
                _database.Insert(seedparticipant2);

            }

            if (_database.Table<OpenDumpsite>().Count() == 0)
            {

                var seedDumpsite = new OpenDumpsite();
                
                seedDumpsite.WasteTypes = "E-waste";
                seedDumpsite.StreetName = "69 Waste Street";
                seedDumpsite.ImageUrl = "1";
                seedDumpsite.Comment = "Waste everwhere";
                

                var seedDumpsiteMarker = new DumpsiteMarker();
                
                seedDumpsiteMarker.PinAddress = "69 Waste Street";
                seedDumpsiteMarker.PinLabel = "Dumpsite";
                seedDumpsiteMarker.Latitude = -34.031405M;
                seedDumpsiteMarker.Longitude = 18.589430M;

                _database.Insert(seedDumpsiteMarker);
                _database.Insert(seedDumpsite);

                seedDumpsite.DumpsiteMarker = seedDumpsiteMarker; //build the adding function

               

                _database.UpdateWithChildren(seedDumpsite);
               // _database.DropTable<OpenDumpsite>();
               // _database.DropTable<DumpsiteMarker>();
            }
        

            }

        public List<SiteInformation> GetSiteInformations()
        {
              return _database.Table<SiteInformation>().ToList();
        }

        public SiteInformation GetSiteInformations(int id)
        {
            return _database.Table<SiteInformation>().Where(x => x.SiteInformationId == id).FirstOrDefault();
        }

        public List<Event> GetEvents()
        {
            List<Event> tempList = new List<Event>();
            var temp = _database.Table<Event>().ToList();
            foreach (var item in temp)
            {
                if (item != null)
                {
                    _database.GetChildren(item, true);
                    tempList.Add(item);
                }
  
            }
            
            return tempList;
        }

        public Event GetEventDetails(int id)
        {
           
            var temp = _database.Table<Event>().Where(x => x.EventId == id).FirstOrDefault();
            
                
            _database.GetChildren(temp, true);
                    
            return temp;
        }

        public List<Participant> GetParticipants(int id)
        {

            
            var temp = _database.Table<Participant>().Where(x => x.EventId == id).ToList();
            

            return temp;
        }


        public List<OpenDumpsite> GetOpenedDumpsites()
        {
            
            List <OpenDumpsite> tempList = new List<OpenDumpsite>();

            var temp = _database.Table<OpenDumpsite>().ToList();
            
            var temp2 = _database.Table<DumpsiteMarker>().ToList();
           

            foreach (var item in temp)
            {
              if (item != null)
             {
               _database.GetChildren(item,true);
                tempList.Add(item);
             }

            //  }

            //return tempList;

            return _database.Table<OpenDumpsite>().ToList();
        }

        public OpenDumpsite GetOpenedDumpsitedetails(int id)
        {
            
            var temp = _database.Table<OpenDumpsite>().Where(x => x.OpenDumpsiteId == id).FirstOrDefault();
           
            _database.GetChildren(temp, true);
 
            return temp;
        }

        public TempDumpsite GetTempDumpsite()
        {
            TempDumpsite temp = null;

            var templist = _database.Table<TempDumpsite>().ToList();

            foreach (var item in templist)
            {
                if (item != null)
                {
                    temp = item;
                }

            }
            return temp;

        }


        public void AddTempDumpsite(TempDumpsite tempDumpsite)
        {
            

            _database.Insert(tempDumpsite);

        }

        public void AddTempDumpsiteMarker(TempDumpsiteMarker tempDumpsiteMarker)
        {


            _database.Insert(tempDumpsiteMarker);

        }

        public void DeleteTempDumpsite(TempDumpsite tempDumpsite)
        {


            _database.Delete(tempDumpsite);

        }

        public void DeleteTempDumpsiteMarker(TempDumpsiteMarker tempDumpsiteMarker)
        {


            _database.Delete(tempDumpsiteMarker);

        }

        public void AddReport(ReportedDumpsite reportedDumpsite)
        {
            _database.Insert(reportedDumpsite);
        }

        public void AddPendingEvent(PendingEvent pendingEvent)
        {
            _database.Insert(pendingEvent);
        }
    }
}
