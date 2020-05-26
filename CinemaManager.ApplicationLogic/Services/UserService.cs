using CinemaManager.ApplicationLogic.Abstractions;
using CinemaManager.ApplicationLogic.DataModel;
using CinemaManager.ApplicationLogic.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;


namespace CinemaManager.ApplicationLogic.Services
{
    public class UserService
    {
        private readonly IUserRepository userRepository;
        private readonly IFilmRepository filmRepository;
        private readonly ICommentaryRepository commentaryRepository;
        private readonly IReviewRepository reviewRepository;


        public UserService(IUserRepository userRepository, IFilmRepository filmRepository, 
                           ICommentaryRepository commentaryRepository, IReviewRepository reviewRepository)
        {
            this.userRepository = userRepository;
            this.filmRepository = filmRepository;
            this.commentaryRepository = commentaryRepository;
            this.reviewRepository = reviewRepository;
        }

        private Guid ParseID(string Id)
        {
            if (!Guid.TryParse(Id, out Guid IdGuid))
            {
                throw new Exception("Invalid Guid Format");
            }
            return IdGuid;
        }

        public User GetUserById(string Id)
        {
            Guid userIdGuid = ParseID(Id);
            return userRepository.GetUserById(userIdGuid);
        }
        public User GetOwnerByGuid(Guid userGuid)
        {
            var user = userRepository.GetUserByGuid(userGuid);
            if (user == null)
            {
                throw new EntityNotFoundException(userGuid);
            }

            return user;
        }

        public IEnumerable<Commentary> GetUserCommentaries(string userId)
        {
            Guid userIdGuid = ParseID(userId);
            GetOwnerByGuid(userIdGuid);
            return commentaryRepository.GetCommentariesCreatedByUser(userIdGuid);
        }

        public IEnumerable<Review> GetUserReviews(string userId)
        {
            Guid userIdGuid = ParseID(userId);
            GetOwnerByGuid(userIdGuid);
            return reviewRepository.GetReviewsCreatedByUser(userIdGuid);
        }

        public void AddCommentary(Guid ownerId, string message)
        {
            GetOwnerByGuid(ownerId);

            commentaryRepository.Add(new Commentary()
            {
                Id = Guid.NewGuid(),
                Message = message,
                UserId = ownerId
            }) ; ;
        }

        public void AddReview(Guid ownerId, string message)
        {
            GetOwnerByGuid(ownerId);

            reviewRepository.Add(new Review()
            {
                Id = Guid.NewGuid(),
                Message = message,
                UserId = ownerId
            }); ;
        }
    }
}
