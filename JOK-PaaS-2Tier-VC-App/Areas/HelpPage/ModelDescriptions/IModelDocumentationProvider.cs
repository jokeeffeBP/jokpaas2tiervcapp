using System;
using System.Reflection;

namespace JOK_PaaS_2Tier_VC_App.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}