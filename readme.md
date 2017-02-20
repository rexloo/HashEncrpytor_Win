# HashEncryptor
##
Using hash to generate password for specific website or login.

    Example:

    Message = github+user  --->  Message.Sha1 = 59b7010247bcb69c7b99218fda218624740e0d9c
    Key (as master key) = 123   ---> Key.Sha1 = 40bd001563085fc35165329ea1ff5c5ecbdbbeef

    Compute HMACSHA1 result, using Message.Sha1 as message data, and Key.Sha1 as key data.
    HMACSHA1.Result.Hex    : 337092b5307b7cb64d16b2de7ee74f3b030b5cf9
    HMACSHA1.Result.Base64 : MzM3MDkyYjUzMDdiN2NiNjRkMTZiMmRlN2VlNzRmM2IwMzBiNWNmOQ

    Extract initial 6 digits of HMACSHA1.Result.Hex and HMACSHA1.Result.Base64 and mix these 12 digits.
    Final Password : 3M3z7M039M2D
    