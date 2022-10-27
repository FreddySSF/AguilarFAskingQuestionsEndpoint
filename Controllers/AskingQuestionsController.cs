// Fernando Aguilar
// 10-25-2022
// Asking Questions Endpoint
// We will be taking our mini challenge 3 from the combine and converting it to API Format.
// The program will require the user to input two values into the url and it will
// print out a sentence that takes the users input to both questions and add them into the sentence.
// Peer Reviewed By: Reed Goowdin- Functions well, and I like the way the UI works, 
// Well written code.


using Microsoft.AspNetCore.Mvc;

namespace AguilarFAskingQuestionsEndpoint.Controllers;

[ApiController]
[Route("[controller]")]
public class AskingQuestionsController : ControllerBase
{
    [HttpGet]
    [Route("AskQuestions/{name}/{costume}")]

    public string AskQuestions(string name, string costume)
    {
        return $" Hello {name}! So you are dressing as {costume} for Halloween? That is a cool costume!";
    }
}