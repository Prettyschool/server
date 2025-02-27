﻿using Bit.Core.SecretsManager.Entities;

namespace Bit.Core.SecretsManager.Commands.Projects.Interfaces;

public interface ICreateProjectCommand
{
    Task<Project> CreateAsync(Project project);
}
