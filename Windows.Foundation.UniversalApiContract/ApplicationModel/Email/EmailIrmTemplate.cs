// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.EmailIrmTemplate
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email
{
  /// <summary>Represents a template that can be used to create new EmailIrmInfo objects.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(typeof (IEmailIrmTemplateFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  public sealed class EmailIrmTemplate : IEmailIrmTemplate
  {
    /// <summary>Creates a new instance of the EmailIrmTemplate class with the specified ID, name and description.</summary>
    /// <param name="id">The ID for the new template.</param>
    /// <param name="name">The name of the new template.</param>
    /// <param name="description">The description of the new template.</param>
    [MethodImpl]
    public extern EmailIrmTemplate(string id, string name, string description);

    /// <summary>Creates a new instance of the EmailIrmTemplate class.</summary>
    [MethodImpl]
    public extern EmailIrmTemplate();

    /// <summary>Gets or sets the ID for the template.</summary>
    /// <returns>The ID for the template.</returns>
    public extern string Id { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the description of the template.</summary>
    /// <returns>The description of the template.</returns>
    public extern string Description { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the name for the template.</summary>
    /// <returns>The name for the template.</returns>
    public extern string Name { [MethodImpl] get; [MethodImpl] set; }
  }
}
