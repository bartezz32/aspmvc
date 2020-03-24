using System;
using System.Collections.Generic;
using PartyInvites.Controllers;
using PartyInvites.Models;
using Xunit;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Tests{
    public class HomeControllerTests{
        [Fact]
        public void ListActionFiltersNonAttendees(){
            
            HomeController controller = new HomeController(new FakeRepository());
            ViewResult result = controller.ListResponses();
            Assert.Equal(2, (result.Model as IEnumerable<GuestResponse>).Count());
            
        }
    }

    class FakeRepository : IRepository {

        public IEnumerable<GuestResponse> Responses =>
        new List<GuestResponse>{
            new GuestResponse { Name="N1", WillAttend=true},
            new GuestResponse { Name="N2", WillAttend=true},
            new GuestResponse { Name="N3", WillAttend=false}
        };

        public void AddResponse(GuestResponse response){
            throw new NotImplementedException();
        }
       
    }
}