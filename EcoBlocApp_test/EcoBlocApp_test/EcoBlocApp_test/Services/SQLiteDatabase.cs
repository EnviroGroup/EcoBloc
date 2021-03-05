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

           // _database.DropTable<TempUser>();
           // _database.DropTable<Event>();
          //  _database.DropTable<User>();
          //  _database.DropTable<ClosedDumpsite>();
          //  _database.DropTable<EventMarker>();
          //  _database.DropTable<Participant>();
          //  _database.DropTable<OpenDumpsite>();
          //  _database.DropTable<DumpsiteMarker>();
          //  _database.DropTable<PendingEvent>();
          //  _database.DropTable<ReportedDumpsite>();
           // _database.DropTable<SiteInformation>();
           // _database.DropTable<TempDumpsite>();
            //_database.DropTable<TempDumpsiteMarker>();
            //_database.DropTable<TempUser>();
            _database.CreateTable<Event>();
            _database.CreateTable<ClosedDumpsite>();
            _database.CreateTable<EventMarker>();
            _database.CreateTable<Participant>();
            _database.CreateTable<OpenDumpsite>();
            _database.CreateTable<DumpsiteMarker>();
           // _database.CreateTable<PendingEvent>();
            _database.CreateTable<ReportedDumpsite>();
            _database.CreateTable<SiteInformation>();
            _database.CreateTable<TempDumpsite>();
            _database.CreateTable<TempDumpsiteMarker>();
            _database.CreateTable<User>();
            _database.CreateTable<TempUser>();

            
            //_database.DropTable<ClosedDumpsite>();
            //_database.DropTable<Participant>();

            SeedDatabase();


        }

        public string GetDbPath()
        {
            var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "ecobloc.db");

            return path;
        }

        public void SeedDatabase()
        {
            if (_database.Table<TempUser>().Count() == 0)
            {
                var Temp = new TempUser();
                Temp.UserName = "Anon";

                _database.Insert(Temp);


            }
                if (_database.Table<SiteInformation>().Count() == 0)
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
                site.Latitude = -34.032340M;
                site.Longitude = 18.587590M;

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
                site2.Latitude = -34.034460M;
                site2.Longitude = 18.586450M;

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
                site3.Latitude = -34.030290M;
                site3.Longitude = 18.584470M;

                _database.Insert(site3);
            }

            if (_database.Table<Event>().Count() == 0)
            {
                var User1 = new User();
                User1.FirstName = "Bob";
                User1.LastName = "The Builder";
                User1.UserName = "Bob123";
                User1.Password = "Ibuildthings";
                User1.Email = "BobTheBuilder@gmail.com";
                //User1.AddEvent();
                //User1.AddParticipant();

                var User2 = new User();
                User2.FirstName = "Jack";
                User2.LastName = "Crown";
                User2.UserName = "JacksDown";
                User2.Password = "Ifelldown123";
                User2.Email = "JackAttack@gmail.com";
                

                var User3 = new User();
                User3.FirstName = "Jill";
                User3.LastName = "Crown";
                User3.UserName = "JillDown";
                User3.Password = "Ifelldowntoo123";
                User3.Email = "JillCrown@gmail.com";

                

                var seedevent1 = new Event();//
                seedevent1.EventCreationDate = DateTime.Now;
                seedevent1.ReasonForCreation = "Test Event1";
                seedevent1.NameOfEvent = "Test Event1";

                User1.AddEvent(seedevent1);
                _database.Insert(User1);
                _database.UpdateWithChildren(User1);

                var seedopendumpsite = new ClosedDumpsite();//
                seedopendumpsite.WasteTypes = "Litter";
                seedopendumpsite.StreetName = "123 Test Street";
                seedopendumpsite.ImageUrl = "1";
                seedopendumpsite.Comment = "Testing 123!";


                seedevent1.EventDumpsite = seedopendumpsite;
                _database.Insert(seedevent1);
                _database.UpdateWithChildren(seedevent1);


                var seedeventmarker1 = new EventMarker();//
                seedeventmarker1.PinAddress = "123 Test Road 1";
                seedeventmarker1.PinLabel = "Event Pin 1";
                seedeventmarker1.Latitude = -34.031400M;
                seedeventmarker1.Longitude = 18.589480M;

                seedopendumpsite.EventMarker = seedeventmarker1;

                _database.Insert(seedeventmarker1);
                _database.Insert(seedopendumpsite);
                _database.UpdateWithChildren(seedopendumpsite);

                var seedparticipant1 = new Participant();//
                seedparticipant1.Name = "Test Person 1";
                seedparticipant1.ContactDetails = 1234567890;
                seedparticipant1.ReasonForJoining = "Testing the Event 1";
                seedparticipant1.Contribution = "Nothing";

                User2.AddParticipant(seedparticipant1);

                seedevent1.AddParticipant(seedparticipant1);

                _database.Insert(seedparticipant1);

                var seedparticipant2 = new Participant();//
                seedparticipant2.Name = "Test Person 2";
                seedparticipant2.ContactDetails = 1234567890;
                seedparticipant2.ReasonForJoining = "Testing the Event 1";
                seedparticipant2.Contribution = "Nothing";

                User3.AddParticipant(seedparticipant2);
                _database.Insert(User3);
                seedevent1.AddParticipant(seedparticipant2);

                _database.Insert(seedparticipant2);
                _database.UpdateWithChildren(seedevent1);

                //second event
                var seedevent2 = new Event();//
                seedevent2.EventCreationDate = DateTime.Now;
                seedevent2.ReasonForCreation = "Test Event 2";
                seedevent2.NameOfEvent = "Test Event 2";

                User2.AddEvent(seedevent2);
                _database.Insert(User2);
                _database.UpdateWithChildren(User2);

                var seedopendumpsite2 = new ClosedDumpsite();//
                seedopendumpsite2.WasteTypes = "Rubble";
                seedopendumpsite2.StreetName = "123 Test Street 2";
                seedopendumpsite2.ImageUrl = "1";
                seedopendumpsite2.Comment = "Testing 123!";


                seedevent2.EventDumpsite = seedopendumpsite2;
                _database.Insert(seedevent2);
                _database.UpdateWithChildren(seedevent2);


                var seedeventmarker2 = new EventMarker();//
                seedeventmarker2.PinAddress = "123 Test Road 2";
                seedeventmarker2.PinLabel = "Event Pin 2";
                seedeventmarker2.Latitude = -34.031400M;
                seedeventmarker2.Longitude = 18.589480M;

                seedopendumpsite2.EventMarker = seedeventmarker2;

                _database.Insert(seedeventmarker2);
                _database.Insert(seedopendumpsite2);
                _database.UpdateWithChildren(seedopendumpsite2);

                var seedparticipant3 = new Participant();//
                seedparticipant3.Name = "Test Person 3";
                seedparticipant3.ContactDetails = 1234567890;
                seedparticipant3.ReasonForJoining = "Testing the Event";
                seedparticipant3.Contribution = "Nothing";

                User3.AddParticipant(seedparticipant3);

                seedevent2.AddParticipant(seedparticipant3);

                _database.Insert(seedparticipant3);
 
                _database.UpdateWithChildren(seedevent2);

                _database.UpdateWithChildren(User1);
                _database.UpdateWithChildren(User2);
                _database.UpdateWithChildren(User3);

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
                    item.NumberOfParticipants = item.Participants.Count();
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

        public bool CheckUser(string password, string username)
        {
            var temp =_database.Table<User>().ToList();
            foreach (var item in temp)
            {
                if (item.UserName == username && item.Password == password)
                {
                    return true;
                }
            }

            return false;
        }

        public User GetUser(string password, string username)
        {
            var temp = _database.Table<User>().ToList();
            foreach (var item in temp)
            {
                _database.GetChildren(temp, true);
                if (item.UserName == username && item.Password == password)
                {
                    _database.GetChildren(item, true);
                    return item;
                }
            }

            return null; 
        }

        public void AddUser(string username, string firstname, string lastname, string password, string email)
        {
            var tempUser = new User();
            tempUser.UserName = username;
            tempUser.FirstName = firstname;
            tempUser.LastName = lastname;
            tempUser.Password = password;
            tempUser.Email = email;

            _database.Insert(tempUser);
        }

        public TempUser GetTempUser()
        {
            var testlist = _database.Table<TempUser>().ToList();

            var List = _database.Table<TempUser>();

            var person = (from values in List
                          where values.Id == 1
                          select values).FirstOrDefault();

            return person;
        }
             


        public void AddTempUser(User user)
        {
            var testlist = _database.Table<TempUser>().ToList();

            var List = _database.Table<TempUser>();

            var person = (from values in List
                      where values.Id == 1
                      select values).FirstOrDefault();



            //var tempUser = new TempUser();

            person.UserName = user.UserName;
            person.FirstName = user.FirstName;
            person.LastName = user.LastName;
            person.Password = user.Password;
            person.Email = user.Email;
            person.DumpsitesReported = user.DumpsitesReported;

            if (person.FirstName == "Anon")
            {
                person.ClearEvent();
                person.ClearParticipant();
                
            }
            else
            {
                person.EventsCreated = user.EventsCreated;
                person.EventsParticipatedIn = user.EventsParticipatedIn;
                
            }






            
            _database.Update(person);

            var List2 = _database.Table<TempUser>().ToList();





        }


        public void UpdateEvent(Event @event)
        {
          var newevent =  _database.Table<Event>().Where(x => x.EventId == @event.EventId).FirstOrDefault();

            newevent = @event;
            _database.UpdateWithChildren(newevent);
            

        }

        public bool CheckIfUserIsLoggedIn()
        {
           var temp = _database.Table<TempUser>().ToList();

            
                foreach (var item in temp)
                {
                    if (item.FirstName == "Anon")
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
            
            return false;

        }

        public void ClearUser()
        {
            var temp = _database.Table<TempUser>().Where(x => x.Id == 1).FirstOrDefault();

            _database.Delete(temp);
        }
        public List<OpenDumpsite> GetOpenedDumpsites()
        {

            List<OpenDumpsite> tempList = new List<OpenDumpsite>();

            var temp = _database.Table<OpenDumpsite>().ToList();

            var temp2 = _database.Table<DumpsiteMarker>().ToList();


            foreach (var item in temp)
            {
                if (item != null)
                {
                    _database.GetChildren(item, true);
                    tempList.Add(item);
                }

                 }

                return tempList;

                //return _database.Table<OpenDumpsite>().ToList();
           
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
                    _database.GetChildren(item, true);
                    temp = item;
                    }

                }
                return temp;

            }


            public void AddTempDumpsite(TempDumpsite tempDumpsite)
            {


                _database.Insert(tempDumpsite);
            _database.UpdateWithChildren(tempDumpsite);

        }

            public void AddTempDumpsiteMarker(TempDumpsiteMarker tempDumpsiteMarker)
            {


                _database.Insert(tempDumpsiteMarker);

            }

            public void DeleteTempDumpsite(TempDumpsite tempDumpsite)
            {

                _database.Delete(tempDumpsite);
            _database.UpdateWithChildren(tempDumpsite);
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
