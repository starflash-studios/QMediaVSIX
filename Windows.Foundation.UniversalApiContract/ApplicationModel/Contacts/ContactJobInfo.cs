// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.ContactJobInfo
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  /// <summary>Represents job info for a contact.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class ContactJobInfo : IContactJobInfo
  {
    /// <summary>Initializes a new instance of a ContactJobInfo class.</summary>
    [MethodImpl]
    public extern ContactJobInfo();

    /// <summary>Gets and sets the company name of the job info for a contact. The maximum string length for the company name is 64 characters.</summary>
    /// <returns>The company name of the job info for a contact.</returns>
    public extern string CompanyName { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets and sets the company Yomi (phonetic Japanese equivalent) name of the job info for a contact. The maximum string length for the company Yomi name is 200 characters.</summary>
    /// <returns>The company Yomi (phonetic Japanese equivalent) name of the job info for a contact.</returns>
    public extern string CompanyYomiName { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets and sets the department of the job info for a contact. The maximum string length for the department is 100 characters.</summary>
    /// <returns>The department of the job info for a contact.</returns>
    public extern string Department { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets and sets the title of the job info for a contact. The maximum string length for the title is 1024 characters.</summary>
    /// <returns>The title of the job info for a contact.</returns>
    public extern string Title { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets and sets the manager of the job info for a contact. The maximum string length for the manager is 1024 characters.</summary>
    /// <returns>The manager of the job info for a contact.</returns>
    public extern string Manager { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets and sets the office of the job info for a contact. The maximum string length for the office is 40 characters.</summary>
    /// <returns>The office of the job info for a contact.</returns>
    public extern string Office { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets and sets the company address of the job info for a contact. The maximum string length for the company address is 1024 characters.</summary>
    /// <returns>The company address of the job info for a contact.</returns>
    public extern string CompanyAddress { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets and sets the description of the job info for a contact. The maximum string length for the description is 512 characters.</summary>
    /// <returns>The description of the job info for a contact.</returns>
    public extern string Description { [MethodImpl] get; [MethodImpl] set; }
  }
}
