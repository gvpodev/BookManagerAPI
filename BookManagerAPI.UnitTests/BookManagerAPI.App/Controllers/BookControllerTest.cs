using BookManager.Controllers;
using FluentAssertions;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Xunit;

namespace BookManagerAPI.UnitTests.BookManagerAPI.App.Controllers;

public class BookControllerTest
{
    private readonly BookController _controller;

    public BookControllerTest()
    {
        _controller = new BookController();
    }

    [Fact]
    public void When_add_Should_return_ok()
    {
        var response = _controller.Create();

        response.Should().BeAssignableTo<OkResult>();
    }
}