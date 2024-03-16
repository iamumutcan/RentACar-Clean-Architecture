﻿namespace Application.Features.Brands.Commands.Update;

public class UpdatedBrandResponse
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public DateTime CreateDate { get; set; }
    public DateTime UpdateDate { get; set; }
}
