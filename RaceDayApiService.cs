//Services/RaceDayApiService.cs
using RaceDay_MVC.Models;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using static RaceDay_MVC.Models.EventUpdateRequest;


namespace RaceDay_MVC.Services
{
    public class RaceDayApiService
    {
        private readonly HttpClient _httpClient;

        public RaceDayApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        //READ:Get all participants
        public async Task<List<Participants>> GetAllAsync()
        {
            var Participants = await _httpClient
                .GetFromJsonAsync<List<Participants>>("api/participants");

            return Participants ?? new List<Participants>();

        }
        //READ:Get participant by id
        public async Task<Participants?> GetByIdAsync(int id)
        {
            var response = await _httpClient
                .GetAsync($"api/participants/{id}");
            if (response.StatusCode == HttpStatusCode.NotFound)

                return null;

            response.EnsureSuccessStatusCode();

            return await response.Content.ReadFromJsonAsync<Participants>();
        }

        //CREATE: Create a new participant
        public async Task<Participants?> CreateAsync(Participants participant)
        {
            var response = await _httpClient
                .PostAsJsonAsync("api/participants", participant);
            if (response.StatusCode == HttpStatusCode.BadRequest)
            {
                // Handle validation errors here if needed
                return null;
            }
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<Participants>();
        }

        //UPDATE: Update an existing participant
        public async Task<Participants?> UpdateAsync(Participants participant)
        {
            var response = await _httpClient
                .PutAsJsonAsync($"api/participants/{participant.Id}", participant);
            if (response.StatusCode == HttpStatusCode.BadRequest)
            {
                // Handle validation errors here if needed
                return null;
            }
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<Participants>();
        }

        //DELETE: Delete a participant by id
        public async Task<bool> DeleteAsync(int id)
        {
            var response = await _httpClient
                .DeleteAsync($"api/participants/{id}");
            if (response.StatusCode == HttpStatusCode.NotFound)
            {
                return false;
            }
            response.EnsureSuccessStatusCode();
            return true;
        }

        //READ: Get all organizer
        public async Task<List<Organizer>> GetAllRacesAsync()
        {
            var organizers = await _httpClient
                .GetFromJsonAsync<List<Organizer>>("api/organizer");

            return organizers ?? new List<Organizer>();
        }
        //READ: Get organizer by id
        public async Task<Organizer?> GetRaceByIdAsync(int id)
        {
            var response = await _httpClient
                .GetAsync($"api/organizer/{id}");
            if (response.StatusCode == HttpStatusCode.NotFound)
            {
                return null;
            }
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<Organizer>();
        }
        //CREATE: Create a new organizer
        public async Task<Organizer?> CreateRaceAsync(Organizer organizer)
        {
            var response = await _httpClient
                .PostAsJsonAsync("api/organizer", organizer);
            if (response.StatusCode == HttpStatusCode.BadRequest)
            {
                // Handle validation errors here if needed
                return null;
            }
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<Organizer>();
        }
        //UPDATE: Update an existing organizer
        public async Task<Organizer?> UpdateRaceAsync(Organizer organizer)
        {
            var response = await _httpClient
                .PutAsJsonAsync($"api/organizer/{organizer.Id}", organizer);
            if (response.StatusCode == HttpStatusCode.BadRequest)
            {
                // Handle validation errors here if needed
                return null;
            }
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<Organizer>();
        }
        //DELETE: Delete an organizer by id
        public async Task<bool> DeleteRaceAsync(int id)
        {
            var response = await _httpClient
                .DeleteAsync($"api/organizer/{id}");
            if (response.StatusCode == HttpStatusCode.NotFound)
            {
                return false;
            }
            response.EnsureSuccessStatusCode();
            return true;
        }

        //READ: Get all categories
        public async Task<List<Category>> GetAllCategoriesAsync()
        {
            var categories = await _httpClient
                .GetFromJsonAsync<List<Category>>("api/category");
            return categories ?? new List<Category>();
        }
        //READ: Get category by id
        public async Task<Category?> GetCategoryByIdAsync(int id)
        {
            var response = await _httpClient
                .GetAsync($"api/category/{id}");
            if (response.StatusCode == HttpStatusCode.NotFound)
            {
                return null;
            }
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<Category>();

        }
        //CREATE: Create a new category
        public async Task<Category?> CreateCategoryAsync(Category category)
        {
            var response = await _httpClient
                .PostAsJsonAsync("api/category", category);
            if (response.StatusCode == HttpStatusCode.BadRequest)
            {
                // Handle validation errors here if needed
                return null;
            }
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<Category>();
        }
        //UPDATE: Update an existing category
        public async Task<Category?> UpdateCategoryAsync(Category category)
        {
            var response = await _httpClient
                .PutAsJsonAsync($"api/category/{category.Id}", category);
            if (response.StatusCode == HttpStatusCode.BadRequest)
            {
                // Handle validation errors here if needed
                return null;
            }
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<Category>();
        }
        //DELETE: Delete a category by id
        public async Task<bool> DeleteCategoryAsync(int id)
        {
            var response = await _httpClient
                .DeleteAsync($"api/category/{id}");
            if (response.StatusCode == HttpStatusCode.NotFound)
            {
                return false;
            }
            response.EnsureSuccessStatusCode();
            return true;
        }

        //READ: Get all events
        public async Task<List<Event>> GetAllEventsAsync()
        {
            var events = await _httpClient
                .GetFromJsonAsync<List<Event>>("api/event");
            return events ?? new List<Event>();
        }
        //READ: Get event by id
        public async Task<Event?> GetEventByIdAsync(int id)
        {
            var response = await _httpClient
                .GetAsync($"api/event/{id}");
            if (response.StatusCode == HttpStatusCode.NotFound)
            {
                return null;
            }
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<Event>();
        }
        //CREATE: Create a new event
        public async Task<Event?> CreateEventAsync(Event eventObj)
        {
            var response = await _httpClient
                .PostAsJsonAsync("api/event", eventObj);
            if (response.StatusCode == HttpStatusCode.BadRequest)
            {
                // Handle validation errors here if needed
                return null;
            }
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<Event>();
        }
        //UPDATE: Update an existing event
        public async Task<Event?> UpdateEventAsync(Event eventObj)
        {
            var response = await _httpClient
                .PutAsJsonAsync($"api/event/{eventObj.Id}", eventObj);
            if (response.StatusCode == HttpStatusCode.BadRequest)
            {
                // Handle validation errors here if needed
                return null;
            }
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<Event>();
        }
        //DELETE: Delete an event by id
        public async Task<bool> DeleteEventAsync(int id)
        {
            var response = await _httpClient
                .DeleteAsync($"api/event/{id}");
            if (response.StatusCode == HttpStatusCode.NotFound)
            {
                return false;
            }
            response.EnsureSuccessStatusCode();
            return true;
        }
        //READ: Get all results
        public async Task<List<Result?>> GetAllResultsAsync()
        {
            var results = await _httpClient
                .GetFromJsonAsync<List<Result>>("api/resultss");
            return results ?? new List<Result>();
        }
        //READ: Get result by id
        public async Task<Result?> GetResultByIdAsync(int id)
        {
            var response = await _httpClient
                .GetAsync($"api/result/{id}");
            if (response.StatusCode == HttpStatusCode.NotFound)
            {
                return null;
            }
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<    Result>();
        }
        //CREATE: Create a new result
        public async Task<Result?> CreateResultAsync(Result result)
        {
            var response = await _httpClient
                .PostAsJsonAsync("api/result", result);
            if (response.StatusCode == HttpStatusCode.BadRequest)
            {
                // Handle validation errors here if needed
                return null;
            }
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<Result>();
        }
        //UPDATE: Update an existing result
        public async Task<Result?> UpdateResultAsync(Result result)
        {
            var response = await _httpClient
                .PutAsJsonAsync($"api/result/{result.Id}", result);
            if (response.StatusCode == HttpStatusCode.BadRequest)
            {
                // Handle validation errors here if needed
                return null;
            }
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<Result>();
        }
        //DELETE: Delete a result by id
        public async Task<bool> DeleteResultAsync(int id)
        {
            var response = await _httpClient
                .DeleteAsync($"api/result/{id}");
            if (response.StatusCode == HttpStatusCode.NotFound)
            {
                return false;
            }
            response.EnsureSuccessStatusCode();
            return true;
        }
        //READ: Get all registrations
        public async Task<List<Registration>> GetAllRegistrationsAsync()
        {
            var registrations = await _httpClient
                .GetFromJsonAsync<List<Registration>>("api/registration");
            return registrations ?? new List<Registration>();
        }
        //READ: Get registration by id
        public async Task<Registration?> GetRegistrationByIdAsync(int id)
        {
            var response = await _httpClient
                .GetAsync($"api/registration/{id}");
            if (response.StatusCode == HttpStatusCode.NotFound)
            {
                return null;
            }
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<Registration>();
        }
        //CREATE: Create a new registration
        public async Task<Registration?> CreateRegistrationAsync(Registration registration)
        {
            var response = await _httpClient
                .PostAsJsonAsync("api/registration", registration);
            if (response.StatusCode == HttpStatusCode.BadRequest)
            {
                // Handle validation errors here if needed
                return null;
            }
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<Registration>();
        }
        //UPDATE: Update an existing registration
        public async Task<Registration?> UpdateRegistrationAsync(Registration registration)
        {
            var response = await _httpClient
                .PutAsJsonAsync($"api/registration/{registration.Id}", registration);
            if (response.StatusCode == HttpStatusCode.BadRequest)
            {
                // Handle validation errors here if needed
                return null;
            }
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<Registration>();
        }
        //DELETE: Delete a registration by id
        public async Task<bool> DeleteRegistrationAsync(int id)
        {
            var response = await _httpClient
                .DeleteAsync($"api/registration/{id}");
            if (response.StatusCode == HttpStatusCode.NotFound)
            {
                return false;
            }
            response.EnsureSuccessStatusCode();
            return true;
        }
    }
}