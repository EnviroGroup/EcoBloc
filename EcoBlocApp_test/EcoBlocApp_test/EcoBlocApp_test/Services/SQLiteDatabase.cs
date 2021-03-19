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
             // _database.DropTable<User>();
             // _database.DropTable<ClosedDumpsite>();
             // _database.DropTable<EventMarker>();
             // _database.DropTable<Participant>();
             // _database.DropTable<OpenDumpsite>();
            //  _database.DropTable<DumpsiteMarker>();
            //  _database.DropTable<PendingEvent>();
            //  _database.DropTable<ReportedDumpsite>();
            // _database.DropTable<SiteInformation>();
           //  _database.DropTable<TempDumpsite>();
           // _database.DropTable<TempDumpsiteMarker>();
           // _database.DropTable<TempUser>();
            _database.CreateTable<Photo>();
            _database.CreateTable<PlaceHolderDumpsite>();
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
            if (_database.Table<PlaceHolderDumpsite>().Count() == 0)
            {
                var Temp = new PlaceHolderDumpsite();
                Temp.Address = "";
                Temp.Comment = "";
                Temp.ImageUrl = "";
                Temp.Latitude = 0;
                Temp.Longitude = 0;
                Temp.WasteTypes = "";
               

                _database.Insert(Temp);


            }


            if (_database.Table<TempUser>().Count() == 0)
            {
                var Temp = new TempUser();
                Temp.UserName = "Anon";

                _database.Insert(Temp);


            }
                if (_database.Table<SiteInformation>().Count() == 0)
            {
                var site = new SiteInformation();
                site.Name = "Green Business";
                site.ImageUrl = "greenbusiness.jpg"; //get image
                site.About = "Businesses related to the environment";
                site.Address = "123 Green Road";
                site.WebsiteLink = "www.GreenBusiness.com";
                site.PhoneNumber = 1234567890;
                site.PinLabel = "Green Business";
                site.PinAddress = "123 Green Road";
                site.Latitude = -34.032340M;
                site.Longitude = 18.587590M;

                _database.Insert(site);

                var site2 = new SiteInformation();
                site2.Name = "NGO";
                site2.ImageUrl = "noglogo.jpg";
                site2.About = "All NGO's";
                site2.Address = "123 NGO Road";
                site2.WebsiteLink = "www.NGO.com";
                site2.PhoneNumber = 1234567890;
                site2.PinLabel = "NGO";
                site2.PinAddress = "123 NGO Road";
                site2.Latitude = -34.034460M;
                site2.Longitude = 18.586450M;

                _database.Insert(site2);

                var site3 = new SiteInformation();
                site3.Name = "Recycling Plants";
                site3.ImageUrl = "recyclinglogo.jpg";
                site3.About = "All recycling plants";
                site3.Address = "123 Recycling Road";
                site3.WebsiteLink = "www.RecyclingPlant.com";
                site3.PhoneNumber = 1234567890;
                site3.PinLabel = "Recycling Plants";
                site3.PinAddress = "123 Recycling Road";
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
                seedevent1.ReasonForCreation = "Seeding the App with dummy events";
                seedevent1.NameOfEvent = "Test Event 1";

                User1.AddEvent(seedevent1);
                _database.Insert(User1);
                _database.UpdateWithChildren(User1);

                var seedopendumpsite = new ClosedDumpsite();//
                seedopendumpsite.WasteTypes = "Litter";
                seedopendumpsite.StreetName = "123 Event Street";
                seedopendumpsite.ImageUrl = "cleanup.jpg";
                seedopendumpsite.Comment = "Testing 123!";


                seedevent1.EventDumpsite = seedopendumpsite;
                _database.Insert(seedevent1);
                _database.UpdateWithChildren(seedevent1);


                var seedeventmarker1 = new EventMarker();//
                seedeventmarker1.PinAddress = "123 Test Road 1";
                seedeventmarker1.PinLabel = "Event Pin 1";
                seedeventmarker1.Latitude = -34.037400M;
                seedeventmarker1.Longitude = 18.549480M;

                seedopendumpsite.EventMarker = seedeventmarker1;

                _database.Insert(seedeventmarker1);
                _database.Insert(seedopendumpsite);
                _database.UpdateWithChildren(seedopendumpsite);

                var seedparticipant1 = new Participant();//
                seedparticipant1.Name = User2.UserName;
                
                seedparticipant1.ReasonForJoining = "Testing the Event 1";
                seedparticipant1.Contribution = "Nothing";

                User2.AddParticipant(seedparticipant1);

                seedevent1.AddParticipant(seedparticipant1);

                _database.Insert(seedparticipant1);

                var seedparticipant2 = new Participant();//
                seedparticipant2.Name = User3.UserName;
                
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
                seedevent2.ReasonForCreation = "Seeding the App with dummy events";
                seedevent2.NameOfEvent = "Test Event 2";

                User2.AddEvent(seedevent2);
                _database.Insert(User2);
                _database.UpdateWithChildren(User2);

                var seedopendumpsite2 = new ClosedDumpsite();//
                seedopendumpsite2.WasteTypes = "Rubble";
                seedopendumpsite2.StreetName = "124 Event Street ";
                seedopendumpsite2.ImageUrl = "cleanup.jpg";
                seedopendumpsite2.Comment = "Testing 123!";


                seedevent2.EventDumpsite = seedopendumpsite2;
                _database.Insert(seedevent2);
                _database.UpdateWithChildren(seedevent2);


                var seedeventmarker2 = new EventMarker();//
                seedeventmarker2.PinAddress = "123 Test Road 2";
                seedeventmarker2.PinLabel = "Event Pin 2";
                seedeventmarker2.Latitude = -34.027400M;
                seedeventmarker2.Longitude = 18.589480M;

                seedopendumpsite2.EventMarker = seedeventmarker2;

                _database.Insert(seedeventmarker2);
                _database.Insert(seedopendumpsite2);
                _database.UpdateWithChildren(seedopendumpsite2);

                var seedparticipant3 = new Participant();//
                seedparticipant3.Name = User3.UserName;
                
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

                seedDumpsite.WasteTypes = "Rubble";
                seedDumpsite.StreetName = "69 Waste Street";
                seedDumpsite.ImageUrl = "dumpsiteImage.jpg";
                seedDumpsite.Comment = "Waste everwhere";


                var seedDumpsiteMarker = new DumpsiteMarker();

                seedDumpsiteMarker.PinAddress = "69 Waste Street";
                seedDumpsiteMarker.PinLabel = "Test Dumpsite 1";
                seedDumpsiteMarker.Latitude = -34.028405M;
                seedDumpsiteMarker.Longitude = 18.559430M;

                _database.Insert(seedDumpsiteMarker);
                _database.Insert(seedDumpsite);

                seedDumpsite.DumpsiteMarker = seedDumpsiteMarker; 



                _database.UpdateWithChildren(seedDumpsite);


                var seedDumpsite1 = new OpenDumpsite();

                seedDumpsite1.WasteTypes = "E-waste";
                seedDumpsite1.StreetName = "70 E-Waste Street";
                seedDumpsite1.ImageUrl = "dumpsiteImage.jpg";
                seedDumpsite1.Comment = "Waste everwhere";


                var seedDumpsiteMarker1 = new DumpsiteMarker();

                seedDumpsiteMarker1.PinAddress = "70 E-Waste Street";
                seedDumpsiteMarker1.PinLabel = "Test Dumpsite 2";
                seedDumpsiteMarker1.Latitude = -34.061455M;
                seedDumpsiteMarker1.Longitude = 18.579130M;

                _database.Insert(seedDumpsiteMarker1);
                _database.Insert(seedDumpsite1);

                seedDumpsite1.DumpsiteMarker = seedDumpsiteMarker1;



                _database.UpdateWithChildren(seedDumpsite1);

                var seedDumpsite2 = new OpenDumpsite();

                seedDumpsite2.WasteTypes = "Plastic";
                seedDumpsite2.StreetName = "71 Plastic Street";
                seedDumpsite2.ImageUrl = "dumpsiteImage.jpg";
                seedDumpsite2.Comment = "Plastic everwhere";


                var seedDumpsiteMarker2 = new DumpsiteMarker();

                seedDumpsiteMarker2.PinAddress = "71 plastic Streett";
                seedDumpsiteMarker2.PinLabel = "Test Dumpsite 3";
                seedDumpsiteMarker2.Latitude = -34.011405M;
                seedDumpsiteMarker2.Longitude = 18.548430M;

                _database.Insert(seedDumpsiteMarker2);
                _database.Insert(seedDumpsite2);

                seedDumpsite2.DumpsiteMarker = seedDumpsiteMarker2;



                _database.UpdateWithChildren(seedDumpsite2);



                // _database.DropTable<OpenDumpsite>();
                // _database.DropTable<DumpsiteMarker>();
            }


        }

        public void AddPhoto(Photo photo)
        {
            _database.Insert(photo);
        }
        public string GetPhoto()
        {
            var List = _database.Table<Photo>();

            var photo = (from values in List
                            where values.PhotoId == 1
                            select values).FirstOrDefault();



            return photo.StoredImage;
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

        public void UpdateUserDetails(User user)
        {
            var List = _database.Table<User>();

            var person = (from values in List
                          where values.UserName == user.UserName
                          select values).FirstOrDefault();

            person.FirstName = user.FirstName;
            person.LastName = user.LastName;
            person.Email = user.Email;

            _database.Update(person);

            var List1 = _database.Table<User>();

            var person1 = (from values in List1
                          where values.UserName == user.UserName
                          select values).FirstOrDefault();

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

        public PlaceHolderDumpsite GetPlaceHolderDumpsite()
        {
            var List = _database.Table<PlaceHolderDumpsite>();

            var dumpsite = (from values in List
                          where values.PlaceHolderDumpsiteId == 1
                          select values).FirstOrDefault();

            return dumpsite;
  
        }

        public bool AddReportedDumpsite()
        {
            var List = _database.Table<PlaceHolderDumpsite>();

            var dumpsite = (from values in List
                            where values.PlaceHolderDumpsiteId == 1
                            select values).FirstOrDefault();

            var user = GetUserDetails();

            if (dumpsite.Comment == "" || dumpsite.ImageUrl == "" || dumpsite.Latitude == 0 || dumpsite.Longitude == 0 || dumpsite.WasteTypes == "")
            {
                return false;
            }
            else
            {
                var report = new ReportedDumpsite();
                report.Address = dumpsite.Address;
                report.Comment = dumpsite.Comment;
                report.ImageUrl = dumpsite.ImageUrl;
                report.Latitude = dumpsite.Latitude;
                report.Longitude = dumpsite.Longitude;
                report.WasteTypes = dumpsite.WasteTypes;

                _database.Insert(report);

                user.AddReport(report);

                _database.UpdateWithChildren(user);

                dumpsite.Address = "";
                dumpsite.Comment = "";
                dumpsite.ImageUrl = "";
                dumpsite.Latitude = 0;
                dumpsite.Longitude = 0;
                dumpsite.WasteTypes = "";


                _database.Update(dumpsite);

                var List1 = _database.Table<ReportedDumpsite>().ToList();
                return true;
            }
   
        }

        public void UpdatePlaceHolderDumpsite(double lat, double lon)
        {
            var List = _database.Table<PlaceHolderDumpsite>();

            var dumpsite = (from values in List
                            where values.PlaceHolderDumpsiteId == 1
                            select values).FirstOrDefault();

            dumpsite.Latitude = lat;
            dumpsite.Longitude = lon;

            _database.Update(dumpsite);

            var List1 = _database.Table<PlaceHolderDumpsite>().ToList();

        }

        public void UpdatePlaceHolderDumpsite(string image, string comment, string wasteTypes, string address)
        {
            var List = _database.Table<PlaceHolderDumpsite>();

            var dumpsite = (from values in List
                            where values.PlaceHolderDumpsiteId == 1
                            select values).FirstOrDefault();

            dumpsite.ImageUrl = image;
            dumpsite.Comment = comment;
            dumpsite.Address = address;
            dumpsite.WasteTypes = wasteTypes;

            _database.Update(dumpsite);

            var List1 = _database.Table<PlaceHolderDumpsite>().ToList();
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
           

            if (person.FirstName == "Anon")
            {
                person.ClearEvent();
                person.ClearParticipant();
                person.ClearReports();
                
            }
            else
            {
                person.DumpsitesReported = user.DumpsitesReported;
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

        public User GetUserDetails()
        {
            var tempUser = _database.Table<TempUser>().Where(x => x.Id == 1).FirstOrDefault();

            var userDetails = _database.Table<User>().Where((x => x.UserName  == tempUser.UserName  )).FirstOrDefault();

            _database.GetChildren(userDetails, true);

            foreach (var item in userDetails.EventsCreated)
            {
                item.NumberOfParticipants = item.Participants.Count();
            }

            

            

            return userDetails;
        }


        public void ClearUser()
        {
            var temp = _database.Table<TempUser>().Where(x => x.Id == 1).FirstOrDefault();

            temp.UserName = string.Empty;
            temp.FirstName = "Anon";
            temp.LastName = string.Empty;
            temp.Password = string.Empty;
            temp.Email = string.Empty;
            temp.ClearReports();
            temp.ClearEvent();
            temp.ClearParticipant();

            







            _database.Update(temp);
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

        public List<Event> GetEventsParticipatedIn()
        {
           var tempeventlist = new List<Event>();

           var tempuser =  GetUserDetails();

            var temp = _database.Table<Event>().ToList();
            _database.GetChildren(temp, true);
            foreach (var item in temp)
            {
                foreach (var x in item.Participants)
                {
                    foreach (var y in tempuser.EventsParticipatedIn)
                    {
                        if (x == y)
                        {
                            tempeventlist.Add(item);
                        }
                    }
                }
            }

            return tempeventlist;


        }


        public void DeRegisterFromEvent(Event @event)
        {

            var tempuser = GetUserDetails();


            foreach (var x in @event.Participants)
            {
                foreach (var y in tempuser.EventsParticipatedIn)
                {
                    if (x == y)
                    {
                        @event.Participants.Remove(y);
                        tempuser.EventsParticipatedIn.Remove(y);

                        _database.UpdateWithChildren(@event);
                        _database.UpdateWithChildren(tempuser);

                    }
                }
            }


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
            var temp2 = _database.Table<TempDumpsite>().ToList();
        }

            public void DeleteTempDumpsiteMarker(TempDumpsiteMarker tempDumpsiteMarker)
            {


                _database.Delete(tempDumpsiteMarker);

            }

        public void ClearTempdumpsite()
        {


            _database.DeleteAll<TempDumpsite>();
            _database.DeleteAll<TempDumpsiteMarker>();

        }



        public void AddReport(ReportedDumpsite reportedDumpsite)
            {
                _database.Insert(reportedDumpsite);
            }

            public void AddPendingEvent(PendingEvent pendingEvent, TempDumpsite tempDumpsite)
            {
            var tempUser = _database.Table<TempUser>().Where(x => x.Id == 1).FirstOrDefault();

            //var dumpsite = _database.Table<OpenDumpsite>().Where(x => x.StreetName == tempDumpsite.StreetName).FirstOrDefault();

              // _database.GetChildren(dumpsite, true);


            pendingEvent.EventDumpsite = tempDumpsite;

                var user = _database.Table<User>().Where(x => x.UserName == tempUser.UserName).FirstOrDefault();

                _database.GetChildren(user, true);

            user.AddPendingEvent(pendingEvent);

            _database.Insert(pendingEvent);

            _database.Update(user);


            var temp1 = _database.Table<User>().ToList(); //checking database
            var temp2 = _database.Table<PendingEvent>().ToList();
          
        }

        public void AddParticipant(User user, Event @event, Participant participant)
        {
            var tempUser = _database.Table<User>().Where(x => x.Id == user.Id).FirstOrDefault();
            var tempEvent = _database.Table<Event>().Where(x => x.EventId == @event.EventId).FirstOrDefault();

            _database.GetChildren(tempUser, true);
            _database.GetChildren(tempEvent, true);

            tempEvent.AddParticipant(participant);
            tempUser.AddParticipant(participant);

            _database.Insert(participant);

            _database.UpdateWithChildren(tempUser);
            _database.UpdateWithChildren(tempEvent);

            var tempUser1 = _database.Table<User>().Where(x => x.Id == user.Id).FirstOrDefault();
            var tempEvent1 = _database.Table<Event>().Where(x => x.EventId == @event.EventId).FirstOrDefault();

            _database.GetChildren(tempUser1, true);
            _database.GetChildren(tempEvent1, true);

        }

        
    }
}
