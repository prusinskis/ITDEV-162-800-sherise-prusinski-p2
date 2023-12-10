import { HttpClient } from '@angular/common/http';
import { Component, OnInit, ElementRef } from '@angular/core';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {
  posts:any;

  constructor(private http:HttpClient, private _elementRef : ElementRef) { }

  ngOnInit(): void {
      this.http.get('http://localhost:5128/api/posts').subscribe(
      response => {
          this.posts = response; 
          console.log("Component loaded : home")
          for(let post of this.posts) {
            var element = this._elementRef.nativeElement.querySelector("[id='"+post.id+"']")
            console.log("trying for element with id " + post.id)
            if(element !=null) {
              console.log("Setting data-status " + post.done)
              element.setAttribute("data-status",post.done)
            }
            else {
              console.log("element is null")
            }
          }
      },
      error => {console.log(error) }
    );
  }

  markAsDone(id:any) {
    console.log("Mark As Done with id "+id+" clicked!")
    if(this.posts != null) {
      for(let post of this.posts) {
        if(post.id == id) {
          post.done = true;
          this.http.put('http://localhost:5128/api/posts?Content-Type=application/json',post).subscribe(
            response => {post = response; },
            error => {console.log(error) }
            );
          location.reload();
          break
        }
      }
    }
  }

  delete(id:any) {
    console.log("Delete with id "+id+" clicked!")
    if(this.posts != null) {
      for(let post of this.posts) {
        if(post.id == id) {
          const options = {
            body: post
          };
          this.http.delete('http://localhost:5128/api/posts?Content-Type=application/json',options).subscribe(
            response => {post = response; },
            error => {console.log(error) }
            );
          location.reload();
          break
        }
      }
    }
  }

  viewPost(id:any) {
      console.log("viewPost with id "+id+" clicked!")
  }

}
