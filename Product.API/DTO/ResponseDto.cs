﻿namespace Product.API.DTO
{
    public class ResponseDto
    {
        public bool IsSucess { get; set; } = true;
        public List<string > Errors { get; set; }
        public object Result { get; set; }
        public string Message { get; set; }
    }
}
