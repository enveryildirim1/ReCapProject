namespace Core.Utilities.Results.Concrete
{
    public class SuccessDataResult<T> : DataResult<T>
    {
        public SuccessDataResult(T data, string massage) : base(data, true, massage)
        {
            //1.versiyon data+mesajlı
        }
        public SuccessDataResult(T data) : base(data, true)
        {
            //2.versiyon  data
        }


    }
}
