// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.CryptographicBuffer
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Security.Cryptography
{
  /// <summary>Contains static methods that implement data management functionality common to cryptographic operations.</summary>
  [Threading(ThreadingModel.Both)]
  [Static(typeof (ICryptographicBufferStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 100794368)]
  public static class CryptographicBuffer
  {
    /// <summary>Compares two IBuffer objects.</summary>
    /// <param name="object1">Buffer to be used for comparison.</param>
    /// <param name="object2">Buffer to be used for comparison.</param>
    /// <returns>**True** specifies that the buffers are equal. Two buffers are equal if each code point in one matches the corresponding code point in the other.</returns>
    [MethodImpl]
    public static extern bool Compare(IBuffer object1, IBuffer object2);

    /// <summary>Creates a buffer that contains random data.</summary>
    /// <param name="length">Length, in bytes, of the buffer to create.</param>
    /// <returns>Output buffer that contains the random data.</returns>
    [MethodImpl]
    public static extern IBuffer GenerateRandom(uint length);

    /// <summary>Creates a random number.</summary>
    /// <returns>Integer that contains the random data.</returns>
    [MethodImpl]
    public static extern uint GenerateRandomNumber();

    /// <summary>Creates a buffer from an input byte array.</summary>
    /// <param name="value">An array of bytes used to create the buffer.</param>
    /// <returns>Output buffer.</returns>
    [MethodImpl]
    public static extern IBuffer CreateFromByteArray(byte[] value);

    /// <summary>Copies a buffer to an array of bytes.</summary>
    /// <param name="buffer">Input buffer.</param>
    /// <param name="value">An array of bytes that contains the values copied from the input buffer. You must declare the array before calling this method and pass it by using the **ref** keyword. If the buffer for the *input* parameter is empty, then the *value* parameter will be returned as NULL.</param>
    [MethodImpl]
    public static extern void CopyToByteArray(IBuffer buffer, out byte[] value);

    /// <summary>Decodes a string that has been hexadecimal encoded.</summary>
    /// <param name="value">Encoded input string.</param>
    /// <returns>Output buffer that contains the decoded string.</returns>
    [MethodImpl]
    public static extern IBuffer DecodeFromHexString(string value);

    /// <summary>Encodes a buffer to a hexadecimal string.</summary>
    /// <param name="buffer">Input buffer.</param>
    /// <returns>Hexadecimal encoded output string.</returns>
    [MethodImpl]
    public static extern string EncodeToHexString(IBuffer buffer);

    /// <summary>Decodes a string that has been base64 encoded.</summary>
    /// <param name="value">Base64 encoded input string.</param>
    /// <returns>Output buffer that contains the decoded string.</returns>
    [MethodImpl]
    public static extern IBuffer DecodeFromBase64String(string value);

    /// <summary>Encodes a buffer to a base64 string.</summary>
    /// <param name="buffer">Input buffer.</param>
    /// <returns>Base64-encoded output string.</returns>
    [MethodImpl]
    public static extern string EncodeToBase64String(IBuffer buffer);

    /// <summary>Converts a string to an encoded buffer.</summary>
    /// <param name="value">String to be encoded.</param>
    /// <param name="encoding">Encoding format.</param>
    /// <returns>Encoded buffer.</returns>
    [MethodImpl]
    public static extern IBuffer ConvertStringToBinary(
      string value,
      BinaryStringEncoding encoding);

    /// <summary>Converts a buffer to an encoded string.</summary>
    /// <param name="encoding">Encoding format.</param>
    /// <param name="buffer">Data to be encoded.</param>
    /// <returns>A string that contains the encoded data.</returns>
    [MethodImpl]
    public static extern string ConvertBinaryToString(BinaryStringEncoding encoding, IBuffer buffer);
  }
}
