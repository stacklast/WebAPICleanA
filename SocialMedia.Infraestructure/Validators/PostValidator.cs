using System;
using FluentValidation;
using SocialMedia.Core.DTOs;
using FluentValidation.AspNetCore;
using System.Collections.Generic;

namespace SocialMedia.Infraestructure.Validators
{
    public class PostValidator: AbstractValidator<PostDto>
    {
        public PostValidator()
        {
            RuleFor(post => post.Descripcion )
            .NotNull()
            .Length(10, 15);

            RuleFor(post => post.Fecha)
            .NotNull()
            .LessThan(DateTime.Now);
        }
        
    }
}