CREATE TABLE [dbo].[Table] (
    [file_id]       UNIQUEIDENTIFIER NOT NULL,
    [file_name]     VARCHAR(50)   NULL,
    [file_update]   DATE   NULL,
    [file_uploader] BIGINT          NULL,
    [isApproved]    VARCHAR (50) DEFAULT (NULL) NULL,
    CONSTRAINT [FK_FileData_Student] FOREIGN KEY ([file_uploader]) REFERENCES [dbo].[StudentData] ([student_id]),
    CONSTRAINT [PK_Table] PRIMARY KEY ([file_id])
);

